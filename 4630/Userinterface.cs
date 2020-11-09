using System;
using System.Collections.Generic;


namespace _4630 
{   
    class UserInterface 
    {
        
        public void Run()
        {

            string choice = Console.ReadLine();
            if (choice == "1")
            {

            }
            else if (choice == "2")
            {
                
            }
            else if (choice == "3")
            {
                
            }
            else if (choice == "4")
            {
                
            }
            else if (choice == "a")
            {
                
            }
            else
            {
                Console.WriteLine("fel");
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