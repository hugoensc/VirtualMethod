using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethod
{
    class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {

        }

        public override double Area()
        {
            return PI * x * x;
        }
    }
}
