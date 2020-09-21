using System;

namespace _4016
{
   class Program
  {
      static void Main(string[] args)
      {
          // kör koden för uppgift 1A
          
          Uppgift_1A();

          // kör koden för uppgift 1B
          Uppgift_1B();

          Uppgift_2A();
          

          Uppgift_3A();

          Uppgift_3B();

          Uppgift_3C();

          Uppgift_3D();

          Uppgift_3E();
          
          Uppgift_4A();

          Uppgift_5A();
          
          Uppgift_6A();


      }

      static void Uppgift_1A()
      {
          double tal = 2.71;
          Console.WriteLine(tal);
          


      }
      

      static void Uppgift_1B()
      {
          // lösning till uppgiften här
          String namn = "babbage";
          Console.WriteLine(namn);
      }

      static void Uppgift_2A()
      {
          Console.WriteLine("Skriv ett heltal");
         
          String text = Console.ReadLine();
          int tal = Convert.ToInt32(text);

  // Om talet är större eller lika med noll, 
  // skriv att det är positivt
  // Annars, skriv att det är negativt
  // din kod ...
    if (tal >= 0)
    {
        Console.WriteLine("det är posiitivt");
    }
    else
    {
        Console.WriteLine("de tär negativt");
    }
    if (tal % 2 == 0)
    {
        Console.WriteLine("det är jämnt");
    }
    else
    {
        Console.WriteLine("det är udda");
    }

  // om talet är jämt berätta detta,
  // annars säg att det är udda
  // Tips 11 % 2 = 1, 10 % 2 = 0, 8 % 2 = 0, 7 % 2 = 1
    }
    static void Uppgift_3A()
    {
        int räknare = 3;
        while (räknare <= 9)
        {
            Console.WriteLine(räknare);
            räknare++;

        }
    }

    static void Uppgift_3B()
    {
        int nr = 4;
        while (nr <=13)
        {
            Console.WriteLine(nr);
            nr += 3;
        }
    }
    static void Uppgift_3C()
    {
        for (int i = 4; i <= 13; i+=3)
        {
            Console.WriteLine(i);
        }
    }
    static void Uppgift_3D()
    {
        int räknare = 30;
        while (räknare >= 15)
        {
            Console.WriteLine(räknare);
            räknare -= 5;

        }
    }
    static void Uppgift_3E()
    {
        for (int i = 30; i >= 15; i-=5)
        {
            Console.WriteLine(i);
        }
    }
    static void Uppgift_4A()
    {
        int[] array1 = {7, 11, 17, 29,};
        Console.WriteLine("");
        foreach (int item in array1)
        {
            Console.WriteLine(item);
        }
    }
    static void Uppgift_5A()
    {
      
        Namn();

        static string Rnamn()
        {
            Console.WriteLine("vad heter du?");
            string namn1 = Console.ReadLine();
            return namn1;
        }
        Console.WriteLine("du heter " + Rnamn());
        

    }
      static void Namn()
        {
            Console.WriteLine("vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("du heter " + namn);
        }

         static string Rnamn()
        {
            Console.WriteLine("vad heter du?");
            string namn1 = Console.ReadLine();
            return namn1;
        }
    static void Uppgift_6A()
    {
        static double Addera(double tal11, double tal22)
        {
            
            double result;
            result = tal22 + tal11;
            return result;



        }
        Console.WriteLine("skriv ett tal");
            string tal1 = Console.ReadLine();
            double tal11 = Convert.ToDouble(tal1);

            Console.WriteLine("skriv ett tal");
            string tal2 = Console.ReadLine();
            double tal22 = Convert.ToDouble(tal2);
        Console.WriteLine(tal11 + "+" + tal22 + "=" + Addera(tal11,tal22));
    }

 }
}
