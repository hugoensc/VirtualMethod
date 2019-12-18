using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethod
{
    class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {

        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }
}
