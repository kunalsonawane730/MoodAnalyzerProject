using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy Mood")]
        public void TestMethodAnalyzerForHappyMood()
        {
            ///AAA methodology
            ///arrange
            string message = "Im in happy mood";
            string expected = "happy";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            //Act
            string Actual = moodAnalyzer.Analyzer();

            //Assert
            Assert.AreEqual(expected, Actual);
        }
        [TestMethod]
        [TestCategory("Sad Mood")]
        public void TestMethodAnalayzerForSadMood()
        {
            ///AAA methodology
            ///arrange
            string message = "Im in sad mood";
            string expected = "sad";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            //Act
            string Actual = moodAnalyzer.Analyzer();

            //Assert
            Assert.AreEqual(expected, Actual);
        }
        [TestMethod]
        [TestCategory("Null Case")]
        public void GivenNullReturnHappyMood()
        {
            ///AAA methodology
            ///arrange
            string message = null;
            string expected = "happy";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            //Act
            string Actual = moodAnalyzer.Analyzer();

            //Assert
            Assert.AreEqual(expected, Actual);
        }
    }
}