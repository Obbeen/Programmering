using System;

namespace Extrauppgift
{
    abstract class QuestionCard 
    {
        protected String question;
        protected String answer;

        abstract public void PrintQuestion();

        public void GetInput(Score s)
        {
            String A = Console.ReadLine();
            Console.Clear();
            if (A.ToLower() == answer.ToLower())
            {
                Console.WriteLine("rätt!");
            }
            else
            {
                Console.WriteLine("fel!");
                s.AddMaxScore();
            }
            Console.WriteLine("press ENTER to continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                
            }


        }
    }
}