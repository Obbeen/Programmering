using System;
using System.Collections.Generic;

namespace _4060
{
    class Program
    {
        static void Main (string[] args)
        {
            database mydatabase = new database();
            mydatabase.Addshape3D(new Sphere(4));
            mydatabase.Addshape3D(new Cylinder(4, 6.0));
            mydatabase.Addshape3D(new Cube(3.0));
            mydatabase.Print();
        }
        
            
    }
     interface Shape3D
        {
            double Getarea();

            double Getvolume();

            void ToString();
        }




   
}
