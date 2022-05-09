using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {

        /* What I really wanted was to make a abstract Shape class in stead of Square, but to meet the conditions in assignment (g) where all
         * shapes should be printed in one list, I do not see how this could all work together.
        */
        protected double a;



        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Square(double a)
            {
            this.a = a;
            
            }

        public virtual double CalculatePerimeter() 
        {
            return a * 4;
        }

        public virtual double CalculateArea()
        {
            return a * a;
        }
    }
}
