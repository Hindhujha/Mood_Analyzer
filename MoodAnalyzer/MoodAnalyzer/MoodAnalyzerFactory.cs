using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyse(string className,string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if(result.Success)
            {
                try
                {
                    Assembly executing=Assembly.GetExecutingAssembly();
                    Type moodAnalyseType=executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentNullException)
                {
                    throw new CustomException(CustomException.Exception_Type.NO_SUCH_CLASS, "CLASS NOT FOUND");
                }
            }
            else
            {
                throw new CustomException(CustomException.Exception_Type.NO_SUCH_METHOD, "CONSTRUCTOR IS NOT FOUND");
            }
        }
    }
}
