using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace TestingMood
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Mood()
        {
            string expected = "SAD";
            string message = "I AM IN SAD MOOD";
           Program mood = new Program(message);
        string MoodAnalyze = mood.Mood_Analyze();

            Assert.AreEqual(expected, MoodAnalyze);
        }

        [TestMethod]
        [DataRow(null)]
        public void ExceptionHandling(string message)
        {
            string expected = "HAPPY";
   Program mood = new Program(message);

        string MoodAnalyze=mood.Mood_Analyze();
            Assert.AreEqual(expected,MoodAnalyze);

        }

    }
}