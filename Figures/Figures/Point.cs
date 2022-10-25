using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Point
    {
        public Point(double coordinateX, double CoordinateY)
        {
            this.X = coordinateX;
            this.Y = CoordinateY;
        }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
