using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboLib.SM.Pages;

namespace TestSM.RGraphics
{
    public class RGraphics
    {
        public string Text { get; set; }
        public Color TextColor { get; set; }
        public Color BodyColor { get; set; }
        public Color SelectColor { get; set; }
        public bool Selected { get; set; }
        public bool Highlighted { get; set; }

        Size _gridCellSize = new Size();
        protected Size GridCellSize
        {
            get
            {
                return _gridCellSize;
            }
            set
            {
                _gridCellSize = value;
            }
        }

        public RGraphics()
        {
            SelectColor = Color.LawnGreen;
            TextColor = Color.FloralWhite;
        }

        protected void SetGridCellSize(int height, int width)
        {
            _gridCellSize.Height = height;
            _gridCellSize.Width = width;
        }

        public void DrawShape(Graphics graphic, SMEditPanel smEditPanel)
        {
            DrawGraphic(graphic, smEditPanel);
            DrawText(graphic, smEditPanel);
        }

        protected virtual void DrawGraphic(Graphics graphic, SMEditPanel smEditPanel)
        {

        }

        protected virtual Point GetTextLocation()
        {
            return new Point(0, 0);
        }

        protected virtual float GetTextRotation()
        {
            return 0f;
        }

        RectangleF _textRectangle;
        void DrawText(Graphics graphic, SMEditPanel smEditPanel)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                using (var brush = new SolidBrush(TextColor))
                {
                    var scrwidth = Screen.PrimaryScreen.Bounds.Width;
                    float width = scrwidth / smEditPanel.NumOfCells;
                    float fontRatio = smEditPanel.CellWidth / width;
                    float fntSize = 16f * fontRatio;
                    var bkTransform = graphic.Transform.Clone();
                    var font = new Font("Calibri Light", fntSize);
                    var textPos = GetTextLocation();
                    var textRot = GetTextRotation();

                    graphic.TranslateTransform(textPos.X, textPos.Y);
                    graphic.RotateTransform(textRot);

                    var text = Text;

                    //if (!string.IsNullOrEmpty(Prefix))
                    //{
                    //    text = string.Format("{0}{1}", Prefix, text);
                    //}
                    var fontGraphiSize = graphic.MeasureString(text, font);
                    graphic.DrawString(text, font, brush, -(fontGraphiSize.Width / 2), -(fontGraphiSize.Height / 2));
                    _textRectangle = new RectangleF(-(fontGraphiSize.Width / 2), -(fontGraphiSize.Height / 2), fontGraphiSize.Width, fontGraphiSize.Height);

                    //if (Highlighted)
                    //{
                    //    using (var pen = CreateSelectedPen())
                    //    {
                    //        g.DrawRectangles(pen, new RectangleF[] { _textRectangle });
                    //    }
                    //}
                    //else if (Selected)
                    //{
                    //    using (var pen = new Pen(Color, 2))
                    //    {
                    //        g.DrawRectangles(pen, new RectangleF[] { _textRectangle });
                    //    }
                    //}

                    //if (Underline)
                    //{
                    //    using (var pen = new Pen(TextColor, 2))
                    //    {
                    //        g.DrawLine(pen, new PointF(_textRectangle.Left, _textRectangle.Bottom + 2), new PointF(_textRectangle.Right, _textRectangle.Bottom + 2));
                    //    }
                    //}

                    graphic.Transform = bkTransform; // Restore transform
                }
            }
        }

        public virtual bool HitOnShape(Point point)
        {
            return HitOnGraphic(point);
        }

        protected virtual bool HitOnGraphic(Point point)
        {
            return false;
        }
    }
}
