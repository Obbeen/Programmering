using System;

namespace _4050
{
    class Program
    {
        static void Main(string[] args)
        {
            

            databas db = new databas();
            
            Console.WriteLine("välkommen");
            Printmenu();
            String choice = Console.ReadLine();
            while (choice != "a")
            {
            if (choice == "1")
            {
                Console.WriteLine("ange Titel på CD");
                String Titelsak = Console.ReadLine();

                Console.WriteLine("Ange artist");
                String Artistsak = Console.ReadLine();

               

                CD thesak = new CD();
                thesak.Titel = Titelsak;
                thesak.Artist = Artistsak;

                db.Addsaker(thesak);
                
            }
            else if (choice == "2")
            {
                Console.WriteLine("ange titel på DVD");
                String Titelsak = Console.ReadLine();

                Console.WriteLine("ange regisör");
                String regisörsak = Console.ReadLine();

                DVD thesak = new DVD();
                thesak.Titel = Titelsak;
                thesak.Regisör = regisörsak;

                 db.Addsaker(thesak);
                 
            }
            else if (choice == "3")
            {
                Console.WriteLine("ange titel på Bok");
                String Titelsak = Console.ReadLine();

                Console.WriteLine("ange författaren");
                String Författaresak = Console.ReadLine();


                Bok thesak = new Bok();
                thesak.Titel = Titelsak;
                thesak.Författare = Författaresak;

                db.Addsaker(thesak);

            }

            else if(choice == "4")
            {
                db.skrivut();
                
            }
            else
            {
                Console.WriteLine("valet finns inte");
                Printmenu();
            }
            Printmenu();
                choice = Console.ReadLine();
        }

        }
        static void Printmenu()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1 Lägg till en CD");
            Console.WriteLine("2 Lägg till en DVD");
            Console.WriteLine("3 Lägg till en Bok");
            Console.WriteLine("4 skriv ut hela samlingen");
            Console.WriteLine("a avsluta");
        }
    }
}
