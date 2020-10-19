using System;
using System.Collections.Generic;

namespace _4630
{
    class BasOchProvisionsAnstalld : ProvisionsAnstalld

    {
       private double FastLon;

       public BasOchProvisionsAnstalld(string namnet , double provisionen , double forsaljningen, double flon) : base( namnet, provisionen, forsaljningen)
       {
           FastLon = flon;
       }
       public double BeraknaLon()
       {
           return ((provision/100) * forsaljning) + FastLon;
       }
       public override string ToString()
       {
           return base.ToString() + " = månadslön" + Environment.NewLine + " Fastlön " + FastLon + Environment.NewLine + "provision: " + provision + Environment.NewLine + "Försäljning: " + forsaljning; 
       }

    }
}
