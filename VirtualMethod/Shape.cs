using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethod
{
    class Shape
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Shape() 
        {

        }

        public Shape (double x, double y)
        {
            this.x = x;
            this.y = x;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }
}
