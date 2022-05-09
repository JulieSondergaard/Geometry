using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
   public abstract class Shape
    {
        protected double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Shape(double a)
        {
            this.a = a;
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();
    }
}
