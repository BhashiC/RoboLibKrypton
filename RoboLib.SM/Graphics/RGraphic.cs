using RoboLib.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Graphics
{
    public class RGraphic
    {
        /// <summary>
        /// DOF when moving a graphic
        /// </summary>
        [Flags]
        public enum DegreeOfFreedom
        {
            None = 0,
            Location = 1,
            Size = 1 << 1,
            Rotation = 1 << 2,
            All = Location | Size | Rotation
        }

        /// <summary>
        /// Degree of freedom of this graphics
        /// </summary>
        public DegreeOfFreedom DOF { get; set; }

        /// <summary>
        /// True when mouse is moving over the graphic
        /// </summary>
        public bool Highlighted { get; set; }

        /// <summary>
        /// True when user select the graphic
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        /// Prefix to append the text on the graphics ($ for state rerun on error)
        /// </summary>
        public string Prefix { get; set; }
        
        /// <summary>
        /// Text to show on this graphic
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Optional object
        /// </summary>
        public object Tag { get; set; }

        /// <summary>
        /// The selected space name. All location and size data should be specified against this space
        /// </summary>
        public string SelectedSpaceName { get; set; }

        /// <summary>
        /// Indicate that the color of this graphic has been changed
        /// </summary>
        public event Action<RGraphic> evColorChanged;

        Color _defaultColor;
        /// <summary>
        /// Default color of the graphics
        /// </summary>
        public Color DefaultColor
        {
            get
            {
                if (Selected)
                {
                    return SelectedColor;
                }
                else
                {
                    return _defaultColor;
                }
            }
            set
            {
                _defaultColor = value;
                if (evColorChanged != null)
                {
                    evColorChanged(this);
                }
            }
        }

        /// <summary>
        /// Color after select the graphics
        /// </summary>
        public Color SelectedColor { get; set; }

        /// <summary>
        /// Color of the text on the graphic
        /// </summary>
        public Color TextColor { get; set; }

        /// <summary>
        /// Group key of this graphic in RDisplay. Ignore if not use
        /// </summary>
        public string Group { get; private set; }

        public RGraphic()
        {
            DOF = DegreeOfFreedom.All;
            SelectedColor = Color.Coral;
            TextColor = Color.Black;
            SelectedSpaceName = RDisplay.RootSpaceName;
        }

        /// <summary>
        /// Draw graphic and text if any
        /// </summary>
        /// <param name="g"></param>
        /// <param name="display"></param>
        public void Draw(System.Drawing.Graphics g, RDisplay display)
        {
            try
            {
                DrawGraphic(g, display);
                DrawText(g, display);
            }
            catch { }
        }

        RectangleF _textRectangle;
        void DrawText(System.Drawing.Graphics g, RDisplay display)
        {
            if (string.IsNullOrEmpty(Text))
            {
                return;
            }

            using (var brush = new SolidBrush(TextColor))
            {
                var bkupTrasform = g.Transform.Clone();
                var font = new Font("Microsoft San Serif", 8f);
                var textPos = GetTextLocation();
                textPos = display.ToRoot(SelectedSpaceName, textPos);
                g.TranslateTransform(textPos.X, textPos.Y);
                g.RotateTransform(GetTextRotation());
                var text = Text;
            }
        }

        /// <summary>
        /// Draw itself, will be overriden in derived graphic
        /// </summary>
        /// <param name="g">The <see cref="System.Drawing.Graphics"/> object.</param>
        /// <param name="display"></param>
        protected virtual void DrawGraphic(System.Drawing.Graphics g, RDisplay display) { }

        /// <summary>
        /// The the group name of this graphic
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public RGraphic SetGroup(string group)
        {
            Group = group;
            return this;
        }

        /// <summary>
        /// Check whether the point is belong to this graphic or text
        /// </summary>
        /// <param name="p">The point to hit test</param>
        /// <returns>True if the point is in the graphic or text</returns>
        public bool HitTest(PointF p)
        {
            return HitTestText(p) | HitTestGraphic(p);
        }
        private bool HitTestText(PointF p)
        {
            if (string.IsNullOrEmpty(Text) || _textRectangle == null)
            {
                return false;
            }

            var matrix = new Matrix();
            var textPos = GetTextLocation();
            matrix.Translate(textPos.X, textPos.Y);
            matrix.Rotate(GetTextRotation());
            matrix.Invert();
            return _textRectangle.Contains(matrix.TransformPointF(p));
        }

        /// <summary>
        /// Check whether a point is belong to this graphic, will be overriden in derived graphic
        /// </summary>
        /// <param name="p">The point to hit test</param>
        /// <returns>True if the point is in the graphic</returns>
        protected virtual bool HitTestGraphic(PointF p)
        {
            return false;
        }

        /// <summary>
        /// Create selected pen
        /// </summary>
        /// <returns></returns>
        protected Pen CreateSelectedPen()
        {
            return new Pen(Color.Red, 2);
        }

        /// <summary>
        /// Move this graphic
        /// </summary>
        /// <param name="offset">The x and y translation</param>
        protected virtual void Move(PointF offset)
        {

        }

        /// <summary>
        /// Override to provide text location
        /// </summary>
        /// <returns></returns>
        protected virtual PointF GetTextLocation()
        {
            return new PointF(0, 0);
        }

        /// <summary>
        /// Override to provide text rotation
        /// </summary>
        /// <returns></returns>
        protected virtual float GetTextRotation()
        {
            return 0f;
        }

        /// <summary>
        /// Make the custom arrow cap provides line thick
        /// </summary>
        /// <param name="lineThick"></param>
        /// <returns></returns>
        protected CustomLineCap MakeCustomArrowCap(int lineThick)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddLine(new Point(-(1 + lineThick), -(4 + lineThick)), new Point(0, 0));
            path.AddLine(new Point(1 + lineThick, -(4 + lineThick)), new Point(0, 0));

            return new CustomLineCap(null, path);
        }
    }
}
