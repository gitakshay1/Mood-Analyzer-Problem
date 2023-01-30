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
        private object message;

        public MoodAnalyzer(string Mood)
        {
            this.Mood= Mood.ToUpper();
        }
        public string Analyzer()
        {
            try
            {
                if (Mood.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }

                else if (Mood.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException )
            {
                
                return "HAPPY";
            }
           
            
        }
    }
}
