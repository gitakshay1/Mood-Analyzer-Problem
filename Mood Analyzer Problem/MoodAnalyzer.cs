using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    public class MoodAnalyzer
    {
        public string Analyzer(string Mood)
        {
            if(Mood.ToLower().Contains("happy"))
            {
                Console.WriteLine("Happy Mood");
                return Mood.ToLower();
            }
            else
            {
                Console.WriteLine("Sad Mood");
                return Mood.ToLower();
            }
        }
    }
}
