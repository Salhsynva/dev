using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Square : Figure
    {
        public Square(List<Point> points) : base(points)
        {
        }
        public double Side { get; set; }
        public override void CalcArea()
        {
            this.Area = Math.Pow(Side,2);
        }
        public override void CalcCenter()
        {
            double sumX = 0, sumY = 0;
            foreach (var p in Points)
            {
                sumX += p.X;
                sumY += p.Y;
            }
            this.Center = new Point(sumX / 4, sumY / 4);
        }
        public override void CalcPerimetr()
        {
            this.Perimetr = 4 * Side;
        }
        


        public override string ToString()
        {
            return $"{nameof(Square)} - Side:{Side} - Area:{this.Area} - Perimeter:{this.Perimetr}";
        }
    }
}
