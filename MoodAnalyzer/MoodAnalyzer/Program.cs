using System;
namespace MoodAnalyzer
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO MOOD ANALYZER PROGRAMS");
        }

        public string Analyze()
        {
            string Mood = "HAPPY";
            return Mood;
        }

        public string Sad()
        {
            string SAD = "I AM IN SAD MOOD";
            return SAD;
        }

        public string Happy()
        {
            string HAPPY = "I AM IN ANY MOOD";
            return HAPPY;
        }
    }
}
