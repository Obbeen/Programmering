using System;
using System.Collections.Generic;

    namespace _4040
    {
        class CD:Sak
        {
            public String Artist;
            public override void Print()
            {
                Console.WriteLine(Titel + " av " + Artist);
            }
           
        }
        class DVD:Sak
        {
            public String Regisör;
            public override void Print()
            {
                Console.WriteLine(Titel + " av " + Regisör);
            }
           
        }
        class Bok:Sak
        {
            public string Författare;
            public override void Print()
            {
                Console.WriteLine(Titel + " av " + Författare);
            }

        }
        class Sak
        {
            public String Titel;

               public virtual void Print()
            {
                Console.WriteLine(Titel);
            }

        }

        

    }