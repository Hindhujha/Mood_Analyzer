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
        [TestMethod]
        public void MoodAnalyse_Object()
        {
            string message = null;
            object expected = new Program(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzer.Program", "Program");
            expected.Equals(obj);
        }

        [TestMethod]
        public void MoodAnalyse_ParameterizedConstructor()
        { 
            object expected = new Program("HAPPY");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyseParameter("MoodAnalyzer.Program","Program","HAPPY");
            expected.Equals(obj);
        }
        [TestMethod]
        public void ReturnHappy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyzerFactory.InvokeAnalyseMood("HAPPY", "MoodAnalyzer.Main");
            Assert.AreEqual(expected, mood);
        
        }
        [TestMethod]
        public void SetHappyMessage()
        {
            string result = MoodAnalyzerFactory.SetField("HAPPY", "message");
            Assert.AreEqual("HAPPY", result);
        }
    }
}

    