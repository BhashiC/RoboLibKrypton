using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboLib.SM.Pages;

namespace TestSM.RGraphics
{
    public class REllipse : RShapes
    {
        public REllipse(int columnOnGrid, int rowOnGrid)
        {
            ColumnOnGrid = columnOnGrid;
            RowOnGrid = rowOnGrid;
            Text = "NormalState-" + Guid.NewGuid().ToString().Split('-').First();
            BodyColor = Color.SeaGreen;
        }

        protected override void DrawGraphic(Graphics graphic, SMEditPanel smEditPanel)
        {
            Setlocation((ColumnOnGrid - 1) * smEditPanel.CellWidth, (RowOnGrid - 1) * smEditPanel.CellHeight);
            SetCenter(smEditPanel.CellWidth, smEditPanel.CellHeight);
            SetGridCellSize(smEditPanel.CellHeight, smEditPanel.CellWidth);

            var rec = new RectangleF(LocationOnGrid, GridCellSize);
            using (var brush = new SolidBrush(this.BodyColor))
            {
                graphic.FillEllipse(brush, rec);
                graphic.DrawEllipse(new Pen(Color.Black, 1), rec);
            }
            if (Highlighted)
            {
                using (var pen = CreateSelectedPen())
                {
                    graphic.DrawEllipse(pen, rec);
                }
            }
        }

        protected override bool HitOnGraphic(Point point)
        {
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(new RectangleF(LocationOnGrid, GridCellSize));
                return path.IsVisible(point);
            }
        }
    }
}
