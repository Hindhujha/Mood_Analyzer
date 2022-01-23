using System;
namespace MoodAnalyzer
{
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
                if (message.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }


    }
}
