using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace TestingMood
{
    [TestClass]
    public class UnitTest1
    {
       public Program mood = new Program();
       
        [TestMethod]
        public void Mood()//happy
        {
            string Mood = mood.Analyze();
            Assert.AreEqual("HAPPY", Mood);
        }

        [TestMethod] //sad
        public void TestSad()
        {
            string Mood = mood.Sad();
            Assert.AreEqual("I AM IN SAD MOOD", Mood);
        }

        [TestMethod] //any
        public void TestHappy()
        {
            string Mood = mood.Happy();
            Assert.AreEqual("I AM IN ANY MOOD", Mood);
        }
    }
}