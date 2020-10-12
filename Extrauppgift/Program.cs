using System;
using System.Collections.Generic;

namespace Extrauppgift
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Score myScore = new Score();
            List<QuestionCard> questions = new List<QuestionCard>();
           
             List<QuestionCard> fragor = new List<QuestionCard>();
            questions.Add(new QuestionChoice("Vad heter Norges hvudstad?", new List<string>(new string[] { "Oslo", "Stockholm", "Berlin", "London" }), "1"));
            questions.Add(new QuestionChoice("Vad heter Danmarks huvudstad?", new List<string>(new string[] { "Oslo", "Köpenhamn", "New York", "London" }), "2"));
            questions.Add(new QuestionChoice("vad heter Finlands huvudstad?", new List<string>(new string[] { "Alingsås", "Stockholm", "Helsingfors", "Göteborg" }), "3"));

            foreach (var question in questions)
            {
                AskQuestion(question, myScore);
            }

            Console.WriteLine("your score is" + myScore.GetScore() + "/" + myScore.GetMaxScore());
                

        }
         static void AskQuestion(QuestionCard Q, Score s)
         {
             Q.PrintQuestion();
             Q.GetInput(s);
         }
        



             
    }        
}

