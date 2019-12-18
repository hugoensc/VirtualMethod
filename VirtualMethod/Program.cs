using System;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 3.0;
            double h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);

            // Display results.
            Console.WriteLine($"Area od Circle  :   {c.Area()}");
            Console.WriteLine($"Area of Sphere  :   {s.Area()}");
            Console.WriteLine($"Area of Cylinder:   {l.Area()}");
        }
    }
}
