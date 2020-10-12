using System;
using System.Collections.Generic;

    namespace Extrauppgift
    {
        class QuestionText : QuestionCard
        {
            public QuestionText (string q, string ans)
            {
                question = q;
                answer = ans;
            }
            public override void PrintQuestion()
            {
                Console.WriteLine(question);
                Console.WriteLine("");
                Console.WriteLine(" Skriva det rätta svaret och tryck ENTER");
            }
        }
    }