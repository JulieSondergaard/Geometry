using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Rectangle : Square
    {
        
        protected double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public Rectangle(double a, double b) : base(a)
        {
            this.a = a;
            this.b = b;
           
        }

        public override double CalculatePerimeter()
        {
            return (a * 2) + (b * 2);
        }

        public override double CalculateArea()
        {
            return a * b;
        }
    }
}
