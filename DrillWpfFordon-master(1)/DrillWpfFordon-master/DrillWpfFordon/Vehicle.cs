using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfFordon
{
    class Player
    {
        // registratoin number
        // owner
        string ballPlayer;

        public int Goals;

        public  Player(string b, int g)
        {
            ballPlayer = b;

            Goals = g;
        }
        // konstruktor tar registeringsnummer som parameter
        // bara registreringsnummer

        // property för att läsa registreringsnummer

        // property för att läsa och sätta ägare
        public string Ballplayer
        {
            get
            {
                return ballPlayer;
            }
        }
    }
}
