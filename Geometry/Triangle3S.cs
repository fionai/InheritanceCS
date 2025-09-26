using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Triangle3S: Triangle
    {
        public Triangle3S
    (double side, int startX, int startY, int lineWidth, Color color) :
    base(side, side, side, startX, startY, lineWidth, color)
        { } 
    }
}
