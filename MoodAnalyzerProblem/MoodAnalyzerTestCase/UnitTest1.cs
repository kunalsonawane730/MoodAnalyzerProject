using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

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
        public void Given_Nullmood_Expecting_Exception_Result()
        {
            //Arrange
            MoodAnalyzer mood = new MoodAnalyzer(null);
            string expected = "Object reference not set to an instance of an object.";

            //Act
            string actual = mood.Analyzer();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        // TC 3.1:- NULL Given NULL Mood Should Throw MoodAnalysisException
        [TestMethod]
        public void Given_Nullmood_Using_CustomExpection_Return_Null()
        {
            //Arrange
            MoodAnalyzer mood = new MoodAnalyzer(null); //Create object  
            string actual = "";
            try
            {
                //Act
                actual = mood.Analyzer();

            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }

        // TC 3.2- Given Empty Mood Should Throw  MoodAnalysisException 

        [TestMethod]

        public void GivenMood_IfEmpty_ShouldThrowException()
        {
            string actual = "";

            try
            {
                //Arrange
                string message = string.Empty;
                MoodAnalyzer mood = new MoodAnalyzer(message); //Create object 
                //Act
                actual = mood.Analyzer();

            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }
        }
    }
}