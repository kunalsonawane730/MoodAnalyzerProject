using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message;  //instance variable
        public MoodAnalyzer(string message) //parameterized constructor 
        {
            this.message = message;
        }
        public string Analyzer()  //Analyzer method find mood
        {
            try
            {
                //UC3 
                if (this.message.Equals(string.Empty)) 
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_EXCEPTION, "Mood should not be empty");
            }
        }
    }
}
