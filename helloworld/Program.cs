using System;

namespace helloworld
{
    class Program
  {
      static void Main(string[] args)
      {
          // kör koden för uppgift 1A
    
          Uppgift_1A();

          // kör koden för uppgift 1B
          Uppgift_1B();

          Uppgift_1C();

          Uppgift_1D();

          Uppgift_2A();
          

          Uppgift_2B();

          Uppgift_3A();

          Uppgift_3B();

          Uppgift_3C();

          Uppgift_4A();

          Uppgift_4B();

          Uppgift_4C();
          

          Uppgift_5A();
          

          Uppgift_6A();
          
          

          Uppgift_7A();
          

          Uppgift_8A();

          Uppgift_8B();
          

          Uppgift_9A();
          

          Uppgift_9B();
          

          Uppgift_10A();
          

          

      }

      static void Uppgift_1A()
      {
          // lösning till uppgiften här
         Console.WriteLine("Vad heter du?");
            String namn = Console.ReadLine();
            Console.WriteLine("Välkommen " + namn + "!");
            Console.WriteLine();
      }

      static void Uppgift_1B()
      {
          // lösning till uppgiften här
          double bredd = 9.6;
            double höjd = 5.4;
            double area;
            area = bredd * höjd/2;
            Console.WriteLine("rektangel");
            Console.WriteLine("bredd: " + bredd);
            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();
      }
    static void Uppgift_1C()
    {
        Console.WriteLine("bredd");
        String bredd = Console.ReadLine();
          double bredd2 = Convert.ToDouble(bredd);

        
        Console.WriteLine("höjd");
        String höjd = Console.ReadLine();
          double höjd2 = Convert.ToDouble(höjd);
          double area;
          area = bredd2 * höjd2/2;
        Console.WriteLine("area: " + area);  
        
    }
    static void Uppgift_1D()
    {
        Console.WriteLine("nummer1");
        String nummer1 = Console.ReadLine();
        int nummer11 = Convert.ToInt32(nummer1);

        Console.WriteLine("nummer2");
        string nummer2 = Console.ReadLine();
        int nummer22 = Convert.ToInt32(nummer2);
        int summa;
        summa = nummer11 + nummer22;
        Console.WriteLine("summa: " + summa);


    }
    static void Uppgift_2A()
    {
        Console.WriteLine("gissa mitt favorit tal");
        string tal = Console.ReadLine();
        int gissning = Convert.ToInt32(tal);
        if (gissning == 3)
        {
            Console.WriteLine("du gissade rätt!");
        }
        else 
        {
            Console.WriteLine("du gissade fel");
        }

    }
    static void Uppgift_2B()
    {
        Random randomGenerator = new Random ();
        int tärning1 = randomGenerator.Next(1,7);
        Console.WriteLine("första tärningen fick " + tärning1);
        int tärning2 = randomGenerator.Next(1,7);
        Console.WriteLine("andra tärningen fick " + tärning2);

        if (tärning1 == tärning2)
        {
            Console.WriteLine("vinst!");
        }
        else
        {
            Console.WriteLine("förlust");
        }



    }
    static void Uppgift_3A()
    {
        int numloop1 = 1;
        while(numloop1 < 6)
        {Console.WriteLine(numloop1);
        numloop1 += 1;
        }

    }
    static void Uppgift_3B()
    {
        int numloop2 = 5;
        while (numloop2 < 21)
        {
            Console.WriteLine(numloop2);
            numloop2 += 3;
        }

    }
    static void Uppgift_3C()
    {
        int numloop3 = 10;
        while (numloop3 > -1)
        {
            Console.WriteLine(numloop3);
            numloop3 -=1;
        }

    }
    static void Uppgift_4A()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write(i + ",");
        }

    }
    static void Uppgift_4B()
    {
        for (int i = 5; i < 21; i += 3)
        {
            Console.Write(i + ",");
        }

    }
    static void Uppgift_4C()
    {
        for (int i = 11; i > -1; i--)
        {
            Console.WriteLine(i);
        }

    }
    static void Uppgift_5A()
    {
        Console.WriteLine("gissa numret:");
        string sguess = Console.ReadLine();
        double dguess = Convert.ToDouble(sguess);
        while (dguess != 15)
        {
            Console.WriteLine("du gissade fel, gissa igen");
            sguess = Console.ReadLine();
            dguess = Convert.ToDouble(sguess);
        }
        Console.WriteLine("du gissade rätt");


    }
    static void Uppgift_6A()
    {
        Random randomGenerator = new Random ();
        int tärning1 = randomGenerator.Next(1,7);
        Console.WriteLine("första tärningen fick " + tärning1);
        int tärning2 = randomGenerator.Next(1,7);
        Console.WriteLine("andra tärningen fick " + tärning2);

        if (tärning1 + tärning2 == 12)
        {
            Console.WriteLine("storvinst!");
        }
        else if(tärning1 == tärning2)
        {
            Console.WriteLine("liten vinst");
        }
        else
        {
            Console.WriteLine("förlust");
        }

    }
    static void Uppgift_7A()
    {
        int[] array1 = {1, 5, 7, 9, 11, 13,};
        Console.WriteLine("");

    }
    static void Uppgift_8A()
    {
        int[] array1 = {1, 5, 7, 9, 11, 13,};
        Console.WriteLine("");
        foreach (int item in array1)
        {
            Console.WriteLine(item + ",");
        }


    }
    static void Uppgift_8B()
    {
        int[] array1 = {1, 5, 7, 9, 11, 13,};
        Console.WriteLine("");
        foreach (int item in array1)
        {
            Console.WriteLine((item + 1) + ",");
        }

        

    }
    static void Uppgift_9A()
    {
        static void agenten()
        {
            Console.WriteLine("väkommen agent x, DItt uppdrag är...");
        }
        agenten();
    }
    static void Uppgift_9B()
    {
        static double addera()

        {
            Console.WriteLine("ett tal");
            string tal = Console.ReadLine();
            double tal11 = Convert.ToDouble(tal);

            Console.WriteLine("ett tal");
            string tal2 = Console.ReadLine();
            double tal22 = Convert.ToDouble(tal2);
            
            return (tal11 + tal22);
         
        }
          Console.WriteLine(addera());

               static void addera2()
            {
                Console.WriteLine("ett tal");
                string tal3 = Console.ReadLine();
                double tal33 = Convert.ToDouble(tal3);

                Console.WriteLine(addera() + tal33);

            
            }

        addera2();
    } 
    static void Uppgift_10A()
    {
        String[] varor = new string[50];

        Console.WriteLine("skriv in dina varor på inköslistan(skriv stopp när du är klar");

        String matvaror = Console.ReadLine();
        for (int i = 0; matvaror != "stopp"; i++)
        {
            varor[i] = matvaror;
            Console.WriteLine("skriv in dina varor på inköslistan(skriv stopp när du är klar");
            matvaror = Console.ReadLine();

        }
        Console.WriteLine("");
        Console.WriteLine("matlista:");
        foreach (string mat in varor)
        {
            if (mat != null)
            {
                Console.WriteLine(mat);
            }
        }
            
        
    }    
  }
}
