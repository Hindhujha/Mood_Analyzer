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
        [DataRow("I AM IN HAPPY MOOD")]
        public void ExceptionHandling(string message)
        {
            string expected = "HAPPY";
             Program mood = new Program(message);

        string MoodAnalyze=mood.Mood_Analyze();
            Assert.AreEqual(expected,MoodAnalyze);
        }
        
        [TestMethod]
        public void ThrowException_Empty()
        {
            try
            {
                string message = " ";
                Program mood = new Program(message);

                string MoodAnalyze = mood.Mood_Analyze();
            }
            catch(CustomException e)
            {
                Assert.AreEqual("MOOD SHOULD NOT BE EMPTY", e.Message);
            }
        }

        [TestMethod]
        public void ThrowException_Null()
        {
            try
            {
                string message = null;
                Program mood = new Program(message);

                string MoodAnalyze = mood.Mood_Analyze();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("MOOD SHOULD NOT BE NULL", e.Message);
            }
        }

    }
}