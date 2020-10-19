using System;
using System.Collections.Generic;

namespace _4630
{
    class ProvisionsAnstalld : Anstalld
    {
       protected double provision;

       protected double forsaljning;

       public ProvisionsAnstalld(string namnet , double provisionen, double forsaljningen):base(namnet)
       {
           provision = provisionen;
           forsaljning = forsaljningen;
       }
       
       public override double Beraknalon()
       {
           return (provision/100) * forsaljning;
       }

       public override String ToString()
       {
           return base.ToString() + " = månadslön " + Environment.NewLine + "Provision: " + provision + Environment.NewLine + "försäljning: " + forsaljning;
       }
    }
}
