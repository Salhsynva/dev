using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal abstract class Figure
    {
        public Figure(List<Point> points)
        {
            this.Points = points;
            this.CalcPerimetr();
            this.CalcArea();
            this.CalcCenter();
        }
        public double Area { get; protected set; }
        public double Perimetr { get; protected set; }
        public List<Point> Points { get; protected set; }
        public Point Center { get; protected set; }

        public abstract void CalcArea();
        public abstract void CalcPerimetr();
        public abstract void CalcCenter();

    }
}
