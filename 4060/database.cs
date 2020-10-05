using System;
using System.Collections.Generic;

namespace _4060
{
      class database
        {
            List<Shape3D> shapes = new List<Shape3D>();

            public void Print()
            {
                foreach (Shape3D shape in shapes)
                {
                    Console.WriteLine(shape.GetType().Name);
                    shape.ToString();
                    Console.WriteLine("Area: " + shape.Getarea());
                    Console.WriteLine("Volume" + shape.Getvolume());

                }
            }
            public void Addshape3D(Shape3D shape)
            {
                shapes.Add(shape);
            }
        }
}