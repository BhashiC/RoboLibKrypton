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
    public class RDiamond : RShapes
    {
        public RDiamond(int columnOnGrid, int rowOnGrid)
        {
            ColumnOnGrid = columnOnGrid;
            RowOnGrid = rowOnGrid;
            Text = "DecisionState-" + Guid.NewGuid().ToString().Split('-').First();
            BodyColor = Color.BlueViolet;
        }

        private List<PointF> GetVertices()
        {
            return new List<PointF>()
                {
                    new PointF(LocationOnGrid.X + GridCellSize.Width/2, LocationOnGrid.Y),
                    new PointF(LocationOnGrid.X + GridCellSize.Width, LocationOnGrid.Y + GridCellSize.Height/2),
                    new PointF(LocationOnGrid.X + GridCellSize.Width/2, LocationOnGrid.Y + GridCellSize.Height),
                    new PointF(LocationOnGrid.X, LocationOnGrid.Y + GridCellSize.Height/2)
                };
        }

        protected override void DrawGraphic(Graphics graphic, SMEditPanel smEditPanel)
        {
            Setlocation((ColumnOnGrid - 1) * smEditPanel.CellWidth, (RowOnGrid - 1) * smEditPanel.CellHeight);
            SetCenter(smEditPanel.CellWidth, smEditPanel.CellHeight);
            SetGridCellSize(smEditPanel.CellHeight, smEditPanel.CellWidth);

            var vertices = GetVertices();

            using (var brush = new SolidBrush(this.BodyColor))
            {
                graphic.FillPolygon(brush, vertices.ToArray());
                graphic.DrawPolygon(new Pen(Color.Black, 1), vertices.ToArray());
            }

            if (Highlighted)
            {
                using (var pen = CreateSelectedPen())
                {
                    graphic.DrawPolygon(pen, vertices.ToArray());
                }
            }
        }

        protected override bool HitOnGraphic(Point point)
        {
            using (var path = new GraphicsPath())
            {
                path.AddPolygon(GetVertices().ToArray());
                return path.IsVisible(point);
            }
        }
    }
}
