using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    public class MoodAnalyzerReflector
    {
        public static object CreateMoodAnalyse(string className, string constructorName, string message)
        {
            string pattern = @"." + constructorName + "";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCHCLASS, "Class not found");
                }
            }
            else
            {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCHCLASS, "Class not found");
               
            }
        }
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerProblem.MoodAnalyzer");
                object moodAnalyseObject = MoodAnalyzerReflector.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                if (methodInfo == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Method not found");
                }
                object mood = methodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (CustomException e)
            {
                return e.Message;
            }
        }
    }
}
