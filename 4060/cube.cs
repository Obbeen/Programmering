using System;
using System.Collections.Generic;

namespace _4060
{
    class Cube : Shape3D
        {
         private double length;
         public Cube(double length1)
         {
             length = length1;
         } 
        public double Getarea()
        {
            return 6 * length * length;       
        }
        public double Getvolume()
        {
            return length * length * length;
        }
        public void ToString()
        {
            Console.WriteLine("length: " + length);
        }  

        }
}