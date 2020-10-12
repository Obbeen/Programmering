using System;
using System.Collections.Generic;

    namespace Extrauppgift
    {
        class QuestionChoice : QuestionCard
        {
            private List<String> altlist;
            private int altnum = 1;
            public QuestionChoice(String pQuestion, List<String> pAlt, String pAnswer)

            {
                question = pQuestion;
                altlist = pAlt;
                answer = pAnswer;
            }
            public override void PrintQuestion()
            {
                Console.WriteLine(question);
                Console.WriteLine("");
                foreach (var alt in altlist)
                {
                    Console.WriteLine(altnum + " - " + alt);
                    altnum++;
                }
                Console.WriteLine("");
                Console.WriteLine("skriv det rätta svara och tryck ENTER");
            }
        }
    }