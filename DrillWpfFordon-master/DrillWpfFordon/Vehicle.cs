using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfFordon
{
    class Vehicle
    {
        // registratoin number
        // owner
        string agare;

        string regnummer;

        public Vehicle(string a, string reg)
        {
            agare = a;

            regnummer = reg;
        }
        // konstruktor tar registeringsnummer som parameter
        // bara registreringsnummer

        // property för att läsa registreringsnummer

        // property för att läsa och sätta ägare
    }
}
