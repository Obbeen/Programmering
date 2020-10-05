using System;
using System.Collections.Generic;

namespace _4060
{
    class Cylinder : Shape3D
        {
            private double radius;
            private double height;
            public Cylinder(double radius1, double height1)
            {
                radius = radius1;
                height = height1;
            }

            public double Getarea()
            {
                return 2 * Math.PI * radius * radius * height + Math.PI * radius * radius;
            }
            public double Getvolume()
            {
                return Math.PI * radius * radius * height;
            }
            public void ToString()
            {
                Console.WriteLine("radius: " + radius);
                Console.WriteLine("height: " + height);
            }
        }
}