using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Shape
    {       

        public Square(double a) : base(a)
            {
            this.a = a;
            
            }

        public override double CalculatePerimeter() 
        {
            return a * 4;
        }

        public override double CalculateArea()
        {
            return a * a;
        }
    }
}
