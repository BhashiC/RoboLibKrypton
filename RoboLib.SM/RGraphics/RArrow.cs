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
    public class RArrow : RGraphics
    {
        /// <summary>
        /// Starting point of the line
        /// </summary>
        Point StartPoint { get; set; }

        /// <summary>
        /// Ending point of the line
        /// </summary>
        Point EndPoint { get; set; }

        Point _centerPoint;
        /// <summary>
        /// Center point of the line  
        /// </summary>
        Point CenterPoint
        {
            get
            {
                return _centerPoint;
            }
            set
            {
                _centerPoint = value;
            }
        }

        public string StartShapeName { get; set; }

        public string EndShapeName { get; set; }

        /// <summary>
        /// Thickness of the line
        /// </summary>
        public int Thickness { get; set; }

        /// <summary>
        /// Line cap for start point
        /// </summary>
        public LineCap StartLineCap { get; set; }

        /// <summary>
        /// Line cap for end point
        /// </summary>
        public LineCap EndLineCap { get; set; }

        /// <summary>
        /// Dash style of the line
        /// </summary>
        public DashStyle DashStyle { get; set; }

        public int StartCellColNum { get; set; }
        public int StartCellRowNum { get; set; }
        public int EndCellColNum { get; set; }
        public int EndCellRowNum { get; set; }

        Point _startCellLocation = new Point();
        Point StartCellLocation
        {
            get
            {
                return _startCellLocation;
            }
            set
            {
                _startCellLocation = value;
            }
        }

        Point _endCellLocation = new Point();
        Point EndCellLocation
        {
            get
            {
                return _endCellLocation;
            }
            set
            {
                _endCellLocation = value;
            }
        }

        /*
        *    P1
        * P4    P2
        *    P3
        */
        private List<Point> GetStartCellVertices()
        {
            return new List<Point>()
                {
                    new Point(StartCellLocation.X + GridCellSize.Width/2, StartCellLocation.Y),
                    new Point(StartCellLocation.X + GridCellSize.Width, StartCellLocation.Y + GridCellSize.Height/2),
                    new Point(StartCellLocation.X + GridCellSize.Width/2, StartCellLocation.Y + GridCellSize.Height),
                    new Point(StartCellLocation.X, StartCellLocation.Y + GridCellSize.Height/2)
                };
        }

        /*
         *    Q1
         * Q4    Q2
         *    Q3
        */
        private List<Point> GetEndCellVertices()
        {
            return new List<Point>()
                {
                    new Point(EndCellLocation.X + GridCellSize.Width/2, EndCellLocation.Y),
                    new Point(EndCellLocation.X + GridCellSize.Width, EndCellLocation.Y + GridCellSize.Height/2),
                    new Point(EndCellLocation.X + GridCellSize.Width/2, EndCellLocation.Y + GridCellSize.Height),
                    new Point(EndCellLocation.X, EndCellLocation.Y + GridCellSize.Height/2)
                };
        }


        public RArrow(int strCelColNum, int strCelRowNum, int endCelColNum, int endCelRowNum, string startShapeName, string endShapeName)
        {
            StartCellColNum = strCelColNum;
            StartCellRowNum = strCelRowNum;
            EndCellColNum = endCelColNum;
            EndCellRowNum = endCelRowNum;
            StartShapeName = startShapeName;
            EndShapeName = endShapeName;
             
            _centerPoint = new Point();

            Thickness = 2;
            BodyColor = Color.HotPink;
            EndLineCap = LineCap.ArrowAnchor;
            Text = Text = "Transition-" + Guid.NewGuid().ToString().Split('-').First();
        }

        void CalculateStartAndEndPoints()
        {
            var x = StartCellLocation.X.CompareTo(EndCellLocation.X);
            var y = StartCellLocation.Y.CompareTo(EndCellLocation.Y);

            switch (x)
            {
                case 0 when y == 0:
                    break; // Same cell cannot draw an arrow (invalid inputs)
                case 0 when y == -1:
                    StartPoint = GetStartCellVertices().ElementAt(2);
                    EndPoint = GetEndCellVertices().ElementAt(0);
                    break;
                case 0 when y == 1:
                    StartPoint = GetStartCellVertices().ElementAt(0);
                    EndPoint = GetEndCellVertices().ElementAt(2);
                    break;
                case 1:
                    StartPoint = GetStartCellVertices().ElementAt(3);
                    EndPoint = GetEndCellVertices().ElementAt(1);
                    break;
                case -1:
                    StartPoint = GetStartCellVertices().ElementAt(1);
                    EndPoint = GetEndCellVertices().ElementAt(3);
                    break;
            }
        }

        protected override void DrawGraphic(Graphics graphic, SMEditPanel smEditPanel)
        {
            _startCellLocation.X = (StartCellColNum - 1) * smEditPanel.CellWidth;
            _startCellLocation.Y = (StartCellRowNum - 1) * smEditPanel.CellHeight;
            _endCellLocation.X = (EndCellColNum - 1) * smEditPanel.CellWidth;
            _endCellLocation.Y = (EndCellRowNum - 1) * smEditPanel.CellHeight;

            SetGridCellSize(smEditPanel.CellHeight, smEditPanel.CellWidth);
            CalculateStartAndEndPoints();
            SetCenterPoint();

            using (var pen = CreateLinePen(false))
            {
                graphic.DrawLine(pen, StartPoint, EndPoint);
            }

            if (Highlighted)
            {
                using (var pen = CreateLinePen(true))
                {
                    graphic.DrawLine(pen, StartPoint, EndPoint);
                }
            }
        }

        protected Pen CreateLinePen(bool selectPen)
        {
            Pen pen = new Pen(BodyColor, Thickness) { DashStyle = this.DashStyle, StartCap = StartLineCap, EndCap = EndLineCap };
            if (selectPen)
            {
                pen.Color = SelectColor;
                pen.Width = Thickness + 2;
            }
            if (EndLineCap == LineCap.ArrowAnchor)
            {
                pen.CustomEndCap = MakeCustomArrowCap(Thickness);
            }
            return pen;
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

        protected override bool HitOnGraphic(Point p)
        {
            using (var path = new GraphicsPath())
            {
                path.AddLine(StartPoint, EndPoint);
                using (var pen = CreateLinePen(true))
                {
                    path.Widen(pen);
                }
                return path.IsVisible(p);
            }
        }

        protected override Point GetTextLocation()
        {
            return CenterPoint;
        }

        protected override float GetTextRotation()
        {
            if (EndPoint.X != StartPoint.X)
            {
                var ang = (float)(Math.Atan((float)(EndPoint.Y - StartPoint.Y)
                    / (EndPoint.X - StartPoint.X)) * 180 / Math.PI);
                if (0 < ang && ang <= 90)
                {
                    return ang - 90;
                }
                else
                {
                    return ang + 90;
                }
            }
            else
            {
                return 0f;
            }
        }

        void SetCenterPoint()
        {
            _centerPoint.X = (StartPoint.X + EndPoint.X) / 2;
            _centerPoint.Y = (StartPoint.Y + EndPoint.Y) / 2;
        }
    }
}
