using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Geometry
{
    internal class Circle : Shape
    {
        int radius;
      
        public int Radius
        {
            get => radius;
            set => radius = value;
        }
        public Circle
            (
            int radius,
            int startX, int startY, int lineWidth, Color color
            ) : base(startX, startY, lineWidth, color)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, Radius*2, Radius*2); 
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус: {Radius}");
            base.Info(e);
        }
    }

}
