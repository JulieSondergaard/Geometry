using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Parallelogram : Rectangle
    {

        protected double angle;

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }
        public Parallelogram(double a, double b, double angle) : base(a, b)
        {
            this.a = a;
            this.b = b;
            this.angle = angle;

        }

        public override double CalculateArea()
        {
            return a * b * (Math.Sin(angle));
        }

    }
}
