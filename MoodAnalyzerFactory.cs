using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzerFinal
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if(result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentNullException)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Method not found");
            }
        }
    }
}
