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
        //TC 4.1:- Given MoodAnalyser Class Name Should Return MoodAnalyser Object
        [TestMethod]
        public void Given_MoodAnalyser_ClassName_ShouldReturn_MoodAnalyseObject()
        {
            object expected = new MoodAnalyzer("NULL");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        //TC 4.2- Given Class Name When Improper Should Throw MoodAnalysisException

        [TestMethod]
        public void GivenInvalidClassName_ShouldThrow_MoodAnalyserException()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyser.sampleClass", "MoodAnalyser");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //TC 4.3- Given Class When Constructor Not Proper Should Throw MoodAnalysisException.

        [TestMethod]
        public void GivenClass_WhenNotProper_Constructor_ShouldThrow_MoodAnalyserException()
        {
            string expected = "Constructor is not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyserProblem.MoodAnalyzer ", "MoodAnalyzer");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void GivenMoodAnalyserParameterizedConstructor_ShouldReturnObject()
        {
            object expected = new MoodAnalyzer("I am Parameter constructor");
            object actual = MoodAnalyzerFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyzer.AnalyzeMood", "AnalyzeMood", "I am Parameter constructor");
            expected.Equals(actual);
        }
        /// <summary>
        /// TC-5.2 should throw NO_SUCH_CLASS exception with parameterized constructor.
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void GivenClassNameImproperParameterizedConstructor_ShouldReturnMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyzerFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyser.AnalyzeMood", "AnalyzeMood", "I am Parameter constructor");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// <summary>
        /// TC-5.3 should throw NO_SUCH_CONSTRUCTOR exception with parameterized constructor.
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void GivenImproperParameterizedConstructorName_ShouldReturnMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyzerFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyzer.AnalyzeMood", "AnalyzeMod", "I am Parameter constructor");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// <summary>
        /// UC5-Refactor dry principle
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void GivenMoodAnalyserOptionalVarible_ShouldReturnObject()
        {
            object expected = new MoodAnalyzer("I am Parameter constructor");
            object actual = MoodAnalyzerFactory.CreateMoodAnalyserOptionalVariable("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "I am Parameter constructor");
            expected.Equals(actual);
        }
    }
}