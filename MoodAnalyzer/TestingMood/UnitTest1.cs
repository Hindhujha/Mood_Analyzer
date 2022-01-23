using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace TestingMood
{
    [TestClass]
    public class UnitTest1
    {
       public Program mood = new Program();
       
        [TestMethod]
        public void Mood()
        {
            string Mood = mood.Analyze();
            Assert.AreEqual("HAPPY", Mood);
        }

    }
}