using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Triangle2S: Triangle
    {

        public Triangle2S
            (double side1, double side2, int startX, int startY, int lineWidth, Color color) :
            base (side1, side1, side2, startX, startY, lineWidth, color)
        {  }
    }
}
