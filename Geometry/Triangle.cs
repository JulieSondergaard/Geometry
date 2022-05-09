using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Square
    {
        protected double b;
        protected double c;

        public double B
        {
            get { return b; }
            set { b = value; }
        }public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle(double a, double b, double c) : base(a)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }

        public override double CalculatePerimeter()
        {
            return 0.5 * a * b;
        }
   

        public override double CalculateArea()
        {
            return a + b + c;
        }
    }
}
