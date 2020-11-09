using System;
using System.Collections.Generic;


namespace _4630 
{   
    class UserInterface 
    {
        static Personalhanterare phant = new Personalhanterare
        public void Run()
        {
            PrintMenu();
            String svar = Console.ReadLine();
            while (svar != "a")
            {
                if (svar == "1")
                {
                    Console.WriteLine("");
                    phant.Laggtillanstalld();
                    Console.WriteLine("");                }

                else if (svar =="2")
                {
                   Console.WriteLine(""); 
                   phant.PrintAnställd(); 
                }

                else if (svar =="3")
                {
                    Console.WriteLine("");
                    phant.Printnamnet();
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("Fel inmatning!");
                }

                PrintMenu();
                svar = Console.ReadLine();
            
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. lägg till ny anställd.");
            Console.WriteLine("2. skriv ut uppgifter om anställda");
            Console.WriteLine("3. skriv ut namn på alla an");
            Console.WriteLine("4. ändra uppgifter om anställda");
            Console.WriteLine("a. Avsluta");
        }



    }

}