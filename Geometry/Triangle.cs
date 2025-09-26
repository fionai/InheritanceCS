using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class Triangle: Shape
    {
        double side1;
        double side2;
        double side3;
        //int point1X;
        //int point1Y;
        //int point2X;
        //int point2Y;
        //int point3X;
        //int point3Y;
        public double Side1
        {
            get => side1;
            set => side1 = value;
                //value >= (Side2 + Side3) ? ((Side2 + Side3) / 2 ) :
                //value;        
        }
        public double Side2
        {
            get => side2;
            set => side2 = value;
            //    value >= (side1 + side3) ? ((side1 + side3) / 2) :
            //    value;
        }
        public double Side3
        {
            get => side3;
            set => side3 = value;
            //    value >= (side1 + side2) ? ((side1 + side2) / 2) :
            //    value;
        }
        //public int Point1X
        //{
        //    get => point1X;
        //    set => point1X = StartX;
        //}
        //public int Point1Y
        //{
        //    get => point1Y;
        //    set => point1Y = StartY;
        //}
        //public int Point2X
        //{
        //    get => point2X;
        //    set => point2X = StartX + (int) Side1;
        //}
        //public int Point2Y
        //{
        //    get => point2Y;
        //    set => point2Y = StartY;
        //}
        //public int Point3X
        //{
        //    get => point3X;
        //    set => point3X = StartX + (int)((Side1 * Side1 + Side2 * Side2 - Side3 * Side3) / 2 / Side1);
        //}
        //public int Point3Y
        //{
        //    get => Point3Y;
        //    set => Point3Y = StartY + (int)Math.Sqrt(Side2 * Side2 - Point3X * Point3X);
        //}
        public PointF[] GetPoints()
        {
            //int point1X = StartX + 0;
            //int point1Y = StartY + 0;
            //int point2X = StartX + (int)side1;
            //int point2Y = StartY + 0;
            //int point3X = StartX + (int)((side1 * side1 + side2 * side2 - side3 * side3) / 2 / side1);
            //int point3Y = StartY + (int)Math.Sqrt(side2 * side2 - point3X * point3X);
            PointF[] points = new PointF[3];
            points[0].X = StartX + 0;
            points[0].Y = StartY + 0;
            points[1].X = StartX + (int)Side1;
            points[1].Y = StartY + 0;
            points[2].X = (int)((Side1 * Side1 + Side2 * Side2 - Side3 * Side3) / 2 / Side1);
            points[2].Y = StartY + (int)Math.Sqrt(Side2 * Side2 - points[2].X * points[2].X);
            points[2].X += StartX;
            return points;
        }
        public Triangle
            (
            double side1, double side2, double side3,
            //int point1X, int point1Y, int point2X, int point2Y, int point3X, int point3Y,       
            int startX, int startY, int lineWidth, Color color
            ) : base(startX, startY, lineWidth, color)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            //Point1X = point1X;
            //Point1Y = point1Y;
            //Point2X = point2X;
            //Point2Y = point2Y;
            //Point3X = point3X;
            //Point3Y = point3Y;
        }
        public override double GetArea()
        {
            double p = GetPerimeter()/2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
        public override double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            PointF[] points = new PointF[3];
            points = GetPoints();
            //points[0].X = point1X;
            //points[0].Y = point1Y;
            //points[1].X = point2X;
            //points[1].Y = point2Y;
            //points[2].X = point3X;
            //points[2].Y = point3Y;

            e.Graphics.DrawPolygon(pen, points);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Стороны: {Side1}, {Side2}, {Side3}");
            base.Info(e);
        }
    }
}
