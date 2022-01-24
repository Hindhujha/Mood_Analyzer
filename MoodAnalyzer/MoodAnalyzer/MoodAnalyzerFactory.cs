using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {/// <summary>
     /// 
     ///     
     /// </summary>
     /// <param name="className"></param>
     /// <param name="constructorName"></param>
     ///     /// <param name="message"></param>
     /// <returns></returns>
     /// <exception cref="CustomException"></exception>

        public static object CreateMoodAnalyseParameter(string className, string constructorName, string message)
        {
            Type type = typeof(Program);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                 object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new CustomException(CustomException.Exception_Type.NO_SUCH_METHOD, "CONSTRUCTOR IS NOT FOUND");

                }
            }
            else
            {
                throw new CustomException(CustomException.Exception_Type.NO_SUCH_CLASS, "CLASS NOT FOUND");
            }
          
        }
        

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

        public static string InvokeAnalyseMood(string message,string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzer.Program");
                object moodAnalyseObject = MoodAnalyzerFactory.CreateMoodAnalyseParameter("MoodAnalyzer.Program", "Program", message);
                MethodInfo analyseMoodInfo=type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.Exception_Type.NO_SUCH_METHOD, "METHOD IS NOT FOUND");
            }
        }

     
    }
}

