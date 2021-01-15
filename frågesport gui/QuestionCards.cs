using System;
using System.Collections.Generic;
using System.Text;

namespace frågesport_gui
{
    class questioncards
    {
        public String question { get; }
        public String answer { get; }

        public questioncards(string q, string ans)
        {
            question = q;
            answer = ans;
        }

    }
}
