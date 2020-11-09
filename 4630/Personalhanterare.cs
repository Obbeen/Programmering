using System;
using System.Collections.Generic;

namespace _4630
{
    class Personalhanterare
    {
        protected List<Anstalld> personal = new List<Anstalld>();

        public void Laggtillanstalld()
        {
                Console.WriteLine("vilken sorts anställd?");
                Console.WriteLine("1. Provisionanställd");
                Console.WriteLine("2. Basochprovisions");
                Console.WriteLine("3. Fastanställd");
                Console.WriteLine("4. Timanställd");
                Console.ReadLine();
                string choice1 = Console.ReadLine();

                if (choice1 == "1")
                {               
               Console.WriteLine("");
               Console.WriteLine("Namn: ");
               String namn = Console.ReadLine();
               Console.WriteLine("Månadslön: ");
               String lönen = Console.ReadLine();
               personal.Add(new FastAnstalld(namn, Convert.ToDouble(lönen)));
                }
                else if (choice1 == "2")
                {
               Console.WriteLine("");
               Console.WriteLine("Namn: ");
               String namn = Console.ReadLine();
               Console.WriteLine("Provision(%): ");
               String provision = Console.ReadLine();
               Console.WriteLine("Försäljning: ");
               String forsaljning = Console.ReadLine();
               personal.Add(new ProvisionsAnstalld(namn, Convert.ToDouble(provision), Convert.ToDouble(forsaljning)));                    
                }
                else if (choice1 == "3")
                {
                Console.WriteLine("");
                Console.WriteLine("Namn: ");
                String namn = Console.ReadLine();
                Console.WriteLine("Provision: ");
                String provision = Console.ReadLine();
                Console.WriteLine("Försäljning: ");
                String forsaljning = Console.ReadLine();
                Console.WriteLine("Lön: ");
                String lönen = Console.ReadLine();
                personal.Add(new BasOchProvisionsAnstalld(namn, Convert.ToDouble(provision), Convert.ToDouble(forsaljning), Convert.ToDouble(lönen)));
                }
                else if (choice1 =="4")
                {
                Console.WriteLine("");
                Console.WriteLine("Namn: ");
                String namn = Console.ReadLine();
                Console.WriteLine("Timlön: ");
                String timlon = Console.ReadLine();
                Console.WriteLine("Arbetade timmar: ");
                String timmarna = Console.ReadLine();
                personal.Add(new TimAnstalld(namn, Convert.ToDouble(timlon), Convert.ToDouble(timmarna)));
                }
                else
                {
                    Console.WriteLine("fel");
                }
        }

       public void PrintAnställd()
       {
           foreach (Anstalld item in personal)
           {
               Console.WriteLine(item.ToString());
               Console.WriteLine("");
           }
       }

              public void Printnamnet()
       {
           foreach (Anstalld info in personal)
           {
               Console.WriteLine(info.Namn);
           }
       }
    }
}