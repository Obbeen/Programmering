using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfObject
{
    class Result
    {
        // write code here
        private int distance;

        private string name;

        private int time;



        public Result(string time, string name, string distance)
        {
            this.time = Convert.ToInt32(time);
            this.distance =Convert.ToInt32(distance);
            this.name = name;
        }
         public string tostring()
        {
            string text = "" ;
            text = text + distance + Environment.NewLine;
            text = text + name + Environment.NewLine;
            text = text + time + Environment.NewLine;
            return text;

        }
    }
}
