using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    public class MoodAnalyzer
    {
        private string Mood;

        public MoodAnalyzer(string Mood)
        {
            this.Mood= Mood.ToUpper();
        }
        public string Analyzer()
        {
            try
            {
                if (Mood.ToLower().Contains("sad"))
                {
                    Console.WriteLine("SAD");
                    return "SAD";
                }
                else if(Mood.ToLower().Contains("happy"))
                {
                    Console.WriteLine("HAPPY");
                    return "HAPPY";
                }
                else
                {
                    
                    return "HAPPY";
                }
            }
            catch (NullReferenceException )
            {
                
                return "HAPPY";
            }
           
            
        }
    }
}
