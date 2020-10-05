using System;
using System.Collections.Generic;

namespace _4060
{
     class Sphere: Shape3D
        {
            private double radius;

            public Sphere(double Radius1)
            {
                radius = Radius1;
            }
            public double Getarea()
            {
                return 4 * Math.PI * radius * radius;
            }
            public double Getvolume()
            {
                return (4d/3d) * Math.PI * (radius * radius * radius);
            }
            public void ToString()
            {
                Console.WriteLine("radius: " + radius);
            }
        }
}