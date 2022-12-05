using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using RoboLib.Extensions;

namespace RoboLib.SM.Graphics
{
    public partial class RDisplay : UserControl
    {
        /// <summary>
        /// Zoom constrain enum
        /// </summary>
        public enum ZoomConstrain
        {
            /// <summary>
            /// Zoom only in X direction
            /// </summary>
            XOnly,
            /// <summary>
            /// Zoom only in Y direction
            /// </summary>
            YOnly,
            /// <summary>
            /// Zoom in both direction
            /// </summary>
            Both
        }

        public ZoomConstrain ZoomMethod { get; set; }

        public float ZoomX { get; set; }

        public float ZoomY { get; set; }

        public float Rotation { get; set; }

        public float PanX { get; set; }

        public float PanY { get; set; }

        /// <summary>
        /// Root space name
        /// </summary>
        public const string RootSpaceName = "#";

        /// <summary>
        /// Event to indicates that a graphic is selected
        /// </summary>
        public event Action<RGraphic> evGraphicSelected;

        /// <summary>
        /// Indicated that this graphic is under dragging
        /// </summary>
        public event Action<RGraphic> evGraphicDragging;

        /// <summary>
        /// Indicated that this graphic just finish drag
        /// </summary>
        public event Action<RGraphic> evGraphicDragged;

        public RDisplay()
        {
            InitializeComponent();

            PanX = 0;
            PanY = 0;
            ZoomX = 1f;
            ZoomY = 1f;
            Rotation = 0f;
            ZoomMethod = ZoomConstrain.Both;
        }

        Matrix GetTransformMatrix()
        {
            Matrix matrix = new Matrix();
            matrix.Translate(-this.ClientSize.Width / 2, -this.ClientSize.Height / 2, MatrixOrder.Append);
            matrix.Rotate(Rotation, MatrixOrder.Append);
            matrix.Translate(this.ClientSize.Width / 2 + PanX, this.ClientSize.Height / 2 + PanY, MatrixOrder.Append);
            matrix.Scale(ZoomX, ZoomY, MatrixOrder.Append);
            return matrix;
        }

        /// <summary>
        /// Vertical and horizontal grid lines 
        /// </summary>
        List<RGraphic> _listStaticGraphics = new List<RGraphic>();
        
        /// <summary>
        /// States, Transitions and other dynamic graphics
        /// </summary>
        List<RGraphic> _listInteractiveGraphic = new List<RGraphic>();

        /// <summary>
        /// Add a static graphic to the display
        /// </summary>
        /// <param name="graphic"></param>
        public void AddStaticGraphic(RGraphic graphic)
        {
            _listStaticGraphics.Add(graphic);
        }

        /// <summary>
        /// Clear all static graphics
        /// </summary>
        public void ClearStaticGraphic()
        {
            _listStaticGraphics.Clear();
        }

        /// <summary>
        /// Add an interactive graphic to the display
        /// </summary>
        /// <param name="graphic"></param>
        public void AddInteractiveGraphic(RGraphic graphic)
        {
            _listInteractiveGraphic.Add(graphic);
            graphic.evColorChanged += new Action<RGraphic>(graphic_evColorChanged);
        }

        /// <summary>
        /// Remove a specific interactive graphic
        /// </summary>
        /// <param name="graphic"></param>
        public void RemoveInteractiveGraphic(RGraphic graphic)
        {
            if (graphic != null && _listInteractiveGraphic.Contains(graphic))
            {
                _listInteractiveGraphic.Remove(graphic);
                graphic.evColorChanged -= new Action<RGraphic>(graphic_evColorChanged);
            }
        }

        /// <summary>
        /// Clear all interactive graphic
        /// </summary>
        public void ClearInteractiveGraphic()
        {
            _listInteractiveGraphic.ForEach(graphic => graphic.evColorChanged -= new Action<RGraphic>(graphic_evColorChanged));
            _listInteractiveGraphic.Clear();
        }

        void graphic_evColorChanged(RGraphic graphic)
        {
            Invalidate();
        }

        /// <summary>
        /// Get the selected graphic
        /// </summary>
        /// <returns></returns>
        public RGraphic GetSelectedGraphic()
        {
            return _listInteractiveGraphic.SingleOrDefault(g => g.Selected);
        }


        bool _suspendDrawing = false;

        /// <summary>
        /// Suspend drawing
        /// </summary>
        public void SuspendDrawing()
        {
            _suspendDrawing = true;
        }

        /// <summary>
        /// Resume drawing
        /// </summary>
        public void ResumeDrawing()
        {
            _suspendDrawing = false;
            Invalidate();
        }

        private void RDisplay_Paint(object sender, PaintEventArgs e)
        {
            if (_suspendDrawing)
            {
                return;
            }
            e.Graphics.Transform = GetTransformMatrix();

            foreach (var item in _listStaticGraphics)
            {
                item.Draw(e.Graphics, this);
            }

            foreach (var item in _listInteractiveGraphic)
            {
                item.Draw(e.Graphics, this);
            }
        }


        #region Spaces Handling
        private Dictionary<string, Matrix> _dicSpace = new Dictionary<string, Matrix>();

        /// <summary>
        /// Convert a point to root space
        /// </summary>
        /// <param name="fromSpaceName"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public PointF ToRoot(string fromSpaceName, PointF p)
        {
            if (_dicSpace.ContainsKey(fromSpaceName))
            {
                return _dicSpace[fromSpaceName].TransformPointF(p);
            }
            else
            {
                return p;
            }
        }

        /// <summary>
        /// Convert a point from root space
        /// </summary>
        /// <param name="fromSpaceName"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public PointF FromRoot(string fromSpaceName, PointF p)
        {
            if (_dicSpace.ContainsKey(fromSpaceName))
            {
                var matrix = _dicSpace[fromSpaceName].Clone();
                matrix.Invert();
                return matrix.TransformPointF(p);
            }
            else
            {
                return p;
            }
        }

        /// <summary>
        /// Convert a rectangle to root space
        /// </summary>
        /// <param name="fromSpaceName"></param>
        /// <param name="rec"></param>
        /// <returns></returns>
        public RectangleF ToRoot(string fromSpaceName, RectangleF rec)
        {
            List<PointF> listVertices = new List<PointF>()
            {
                ToRoot(fromSpaceName, new PointF(rec.X, rec.Y)),
                ToRoot(fromSpaceName, new PointF(rec.X + rec.Width, rec.Y)),
                ToRoot(fromSpaceName, new PointF(rec.X + rec.Width, rec.Y + rec.Height)),
                ToRoot(fromSpaceName, new PointF(rec.X, rec.Y + rec.Height))
            };

            var p0 = new PointF(listVertices.Min(p => p.X), listVertices.Min(p => p.Y));
            var p2 = new PointF(listVertices.Max(p => p.X), listVertices.Max(p => p.Y));

            return new RectangleF(p0.X, p0.Y, Math.Abs(p2.X - p0.X), Math.Abs(p2.Y - p0.Y));

        }
        #endregion
    }
}
