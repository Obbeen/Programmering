using System;
using System.Collections.Generic;

namespace _4630
{
    class FastAnstalld : Anstalld
    {
       private double manadslon;

       public FastAnstalld(string namnet, double mlon):base(namnet)
       {
           manadslon = mlon;
       }

       public override double Beraknalon()
       {
           return manadslon;
       }

        public override string ToString()
        {
            return base.ToString() + " = månadslön" + Environment.NewLine;
        }

    }
}
