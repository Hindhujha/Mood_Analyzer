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

        public static object CreateMoodAnalyseWithoutParameter(string className,string constructorName)
        {
            Type type = typeof(Program);
            if(type.Name.Equals(className)||type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    string instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new CustomException(CustomException.Exception_Type.NO_SUCH_METHOD, "CONSTRUCTOR IS NOT FOUND");
                        .
                }
            }
            else
            {
                throw new CustomException(CustomException.Exception_Type.NO_SUCH_CLASS, "CLASS NOT FOUND");
            }
        }
    }
}
