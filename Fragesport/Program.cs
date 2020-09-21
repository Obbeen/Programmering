using System;
using System.Collections.Generic;

namespace Fragesport
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Frågesport();
        }
        
        static void Frågesport()
        {       
            /*
            Console.WriteLine("vad heter Norges huvudstad?");
            String q1 = Console.ReadLine();
            if (q1 == "Oslo")
            {
                Console.WriteLine("rätt");
            }
            else
            {
                Console.WriteLine("fel");
            }

            Console.WriteLine("vad heter Danmarks huvudstad?");
            String q2 = Console.ReadLine();
            if (q2 == "Köpenhamn")
            {
                Console.WriteLine("rätt");
            }
            else
            {
                Console.WriteLine("fel");
            }

            Console.WriteLine("vad heter Finlands huvudstad?");
            String q3 = Console.ReadLine();
            if (q3 == "Helsingfors")
            {
                Console.WriteLine("rätt");
            }
            else
            {
                Console.WriteLine("fel");
            }


             String[] frågor1 = {"vad heter Norges huvudstad?", "Oslo"};
             String[] frågor2 = {"vad heter Danmarks huvudstad?", "Köpenhamn"};
             String[] frågor3 = {"Vad heter Finlands huvudstad?", "Helsingfors"};
             String[] [] allafrågor = { frågor1, frågor2, frågor3};
             foreach (var item in allafrågor)
             {
                 Console.WriteLine(item[0]);
                 String fråga1 = Console.ReadLine();
                 if (fråga1 == item[1])
                 {
                    Console.WriteLine("rätt");
                 }
                 else
                 {
                    Console.WriteLine("fel");
                 }
             }
             
    
             List<string> minlista;
             minlista = new List<string>();
             minlista.Add("va heter Norges huvudstad?");
             minlista.Add("Oslo");
             List<string> minlista2;
             minlista2 = new List<string>();
             minlista2.Add("vad heter Danmarks huvudstad?");
             minlista2.Add("Köpenhamn");
             List<string> minlista3;
             minlista3 = new List<string>();
             minlista3.Add("vad heter Finlads huvudstad?");
             minlista3.Add("Helsingfors");
             List<List<string>> minlista4;
             minlista4 = new List<List<string>>();
             minlista4.Add(minlista);
             minlista4.Add(minlista2);
             minlista4.Add(minlista3);
             foreach (var item in minlista4)
             {
                 Console.WriteLine(item[0]);
                 string svar = Console.ReadLine();
                 if (svar == item[1])
                 {
                     Console.WriteLine("rätt");
                 }
                 else
                 {
                     Console.WriteLine("fel");
                 }
             }*/

             List<questioncards> fragor = new List<questioncards>();
            fragor.Add(new questioncards("Vad heter Norges hvudstad?", "Oslo"));
            fragor.Add(new questioncards("Vad heter Danmarks huvudstad?", "Köpenhamn"));
            fragor.Add(new questioncards("vad heter Finlands huvudstad?", "Helsingfors"));
            foreach (var item in fragor)
            {
                Askquestion(item);
            }

            static void  Askquestion(questioncards q)
            {
                Console.WriteLine(q.question);
                String uans = Console.ReadLine();
                if (uans == q.answer)
                {
                    Console.WriteLine("rätt!");
                }
                else
                {
                    Console.WriteLine("fel!");
                }
            }



                
             }


             
        }
        class questioncards
        {
            public String question {get;}
            public String answer {get;}

            public questioncards(string q, string ans)
            {
                question = q;
                answer = ans;
            }

        }
        
    }

