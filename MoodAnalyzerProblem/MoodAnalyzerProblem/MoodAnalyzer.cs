using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message; //instance variable
        public MoodAnalyzer()
        {
            Console.WriteLine("default contructor");
        }
        public MoodAnalyzer(string message) //parameterized constructor 
        {
            this.message = message;
        }
        public string Analyzer()  //Analyzer method find mood
        {
            try
            {
                message = message.ToLower();
                if (this.message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_EXCEPTION, "Message cann't be null");
                }
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
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}
