using System;
using System.Collections.Generic;

namespace _4630
{
    class TimAnstalld : Anstalld
    {
       private double TimLon;

       private double ArbetareTimmar;

       public TimAnstalld(string namnet , double timlonen, double timmar) :base(namnet)
       {
        
           TimLon = timlonen;

           ArbetareTimmar = timmar;

       }
       public override double Beraknalon()
       {
           return TimLon * ArbetareTimmar;
       }

       public override String ToString()
       {
            return base.ToString() + " = månadslön" + Environment.NewLine +  "Timlön: " + TimLon + Environment.NewLine + "Arbetstimmar: " + ArbetareTimmar;       
       }
    }
}
