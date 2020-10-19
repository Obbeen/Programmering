using System;
using System.Collections.Generic;

namespace _4630
{
    abstract class Anstalld
    {
        protected string namn;
    

        

        public Anstalld(String namnet)
        {
           namn = namnet;
        }

        public abstract double Beraknalon();

        public override string ToString()

        {
            return namn + Environment.NewLine + Beraknalon();
        }

    }
}
