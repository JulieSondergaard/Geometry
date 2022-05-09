using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Trapez : Rectangle
    {
        protected double c;
        protected double d;

        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public double D
        {
            get { return d; }
            set { d = value; }
        }

        public Trapez(double a, double b, double c, double d) : base(a, b)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override double CalculatePerimeter()
        {
            return a + b + c + d;
        }

        public override double CalculateArea()
        {
            double s = (a + b - c + d) / 2;

            double h = 2 / (a - c) * Math.Sqrt(s * (s - a + c) * (s - b) * (s - d));

            
            return 0.5 * (a + c) * h;
        }
    }
}
