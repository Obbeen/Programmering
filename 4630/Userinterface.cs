using System;
using System.Collections.Generic;


namespace _4630 
{   
    class UserInterface 
    {
        
        public void Run()
        {
            Console.WriteLine("1. lägg till ny anställd.");
            Console.WriteLine("2. skriv ut uppgifter om anställda");
            Console.WriteLine("3. skriv ut namn på alla an");
            Console.WriteLine("4. ändra uppgifter om anställda");
            Console.WriteLine("a. Avsluta");
            Console.ReadLine();
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("vilken sorts anställd?");
                Console.WriteLine("1. Provisionanställd");
                Console.WriteLine("2. Basochprovisions");
                Console.WriteLine("3. Fastanställd");
                Console.WriteLine("4. Timanställd");
            }

        }



    }
    class Personalhanterare
    {
        List<Personalhanterare> personal = new List<Personalhanterare>();



    }
}