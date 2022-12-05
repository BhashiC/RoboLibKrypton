using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.Extensions
{
    public static class GraphicsExtensions
    {
        /// <summary>
        /// Extension method for matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public static Point TransformPoint(this Matrix matrix, Point point)
        {
            var pts = new Point[] { point };
            matrix.TransformPoints(pts);
            return pts[0];
        }

        /// <summary>
        /// Extension method for matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="pointF"></param>
        /// <returns></returns>
        public static PointF TransformPointF(this Matrix matrix, PointF pointF)
        {
            var pts = new PointF[] { pointF };
            matrix.TransformPoints(pts);
            return pts[0];
        }

        /// <summary>
        /// Get top center point of a rectangle
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public static PointF GetTopCenterPoint(this RectangleF rec)
        {
            return new PointF(rec.X + rec.Width / 2, rec.Y);
        }

        /// <summary>
        /// Get bottom center point of a rectangle
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public static PointF GetBottomCenterPoint(this RectangleF rec)
        {
            return new PointF(rec.X + rec.Width / 2, rec.Y + rec.Height);
        }

        /// <summary>
        /// Get left center point of a rectangle
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public static PointF GetLeftCenterPoint(this RectangleF rec)
        {
            return new PointF(rec.X, rec.Y + rec.Height / 2);
        }

        /// <summary>
        /// Get right center point of a rectangle
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public static PointF GetRightCenterPoint(this RectangleF rec)
        {
            return new PointF(rec.X + rec.Width, rec.Y + rec.Height / 2);
        }
    }
}
