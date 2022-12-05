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
    public class RShapes : RGraphics
    {
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

        public RShapes()
        {
            _centerPoint = new Point();
        }

        public int ColumnOnGrid { get; set; }
        public int RowOnGrid { get; set; }

        Point _locationOnGrid = new Point();
        public Point LocationOnGrid
        {
            get
            {
                return _locationOnGrid;
            }
            set
            {
                _locationOnGrid = value;
            }
        }

        /// <summary>
        /// Create selected pen
        /// </summary>
        /// <returns></returns>
        protected Pen CreateSelectedPen()
        {
            return new Pen(SelectColor, 4);
        }

        public void Setlocation(int x, int y)
        {
            _locationOnGrid.X = x;
            _locationOnGrid.Y = y;
        }

        public void SetCenter(int cellWidth, int cellHeight)
        {
            _centerPoint.X = _locationOnGrid.X + cellWidth / 2;
            _centerPoint.Y = _locationOnGrid.Y + cellHeight / 2;
        }

        protected override Point GetTextLocation()
        {

            return CenterPoint;
        }
    }
}
