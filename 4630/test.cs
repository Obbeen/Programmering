using System;
using System.Collections.Generic;

namespace _4630
{
    class Test
    {
       private List<Anstalld> anstallda = new List<Anstalld>();

       public void Run()
       {
           anstallda.Add(new ProvisionsAnstalld("Ada", 5, 200000));
           anstallda.Add(new FastAnstalld("Beda", 32000));
           anstallda.Add(new TimAnstalld("Babbage", 200, 40));



        foreach (Anstalld anstalld in anstallda)
        {
        Console.WriteLine(anstalld.GetType().Name);
        Console.WriteLine();
        Console.WriteLine(anstalld.ToString());
        Console.WriteLine();

        }       
       }
    }
}
