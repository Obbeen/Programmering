using System;
using System.Collections.Generic;

    namespace _4050
    {
        class CD:Sak
        {
            public String Artist;
            public override void Print()
            {
                Console.WriteLine(" av " + Artist);
            }
           
        }
        class DVD:Sak
        {
            public String Regisör;
            public override void Print()
            {
                Console.WriteLine(" av " + Regisör);
            }
           
        }
        class Bok:Sak
        {
            public string Författare;
            public override void Print()
            {
                Console.WriteLine(" av " + Författare);
            }

        }
        abstract class Sak
        {
            public String Titel;

               public abstract void Print();

        }

        

    }