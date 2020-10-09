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

