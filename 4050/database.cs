using System;
using System.Collections.Generic;

    namespace _4050
    {
        class databas
        {
            List<Sak> saker = new List<Sak>();
            public void Addsaker(Sak minsak)
            {
                saker.Add(minsak);
            }
            public void skrivut()
            {
                foreach (Sak minsak in saker)
                {
                    Console.Write(minsak.Titel);
                    minsak.Print();
                }
            }
         

        }
    }