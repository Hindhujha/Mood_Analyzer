using System;
namespace MoodAnalyzer
{
    public class CustomException : Exception
    {
        public enum Exception_Type
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD,
            NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        private readonly Exception_Type type;

        public CustomException(Exception_Type Type, string message)
        {
            this.type = Type;
        }
    }
    public class Program
    {
        public string message;


        public Program(string message)
            {
            this.message = message;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO MOOD ANALYZER PROGRAMS");
        }

        public string Mood_Analyze()
        {
            try
            {
                if(this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.Exception_Type.EMPTY_MESSAGE, "MOOD SHOULD NOT BE EMPTY");
                }
                if (message.Contains("SAD"))
                {
                    return "SAD";
                }
                if(message.Contains("HAPPY"))
                {
                    return "HAPPY";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.Exception_Type.NULL_MESSAGE, "MOOD SHOULD NOT BE NULL");
            }
        }
    }


}
