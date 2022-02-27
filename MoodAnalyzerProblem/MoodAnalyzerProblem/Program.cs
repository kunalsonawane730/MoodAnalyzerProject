// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using MoodAnalyzerProblem;
//string message1 = "I am in happy mood";
//MoodAnalyzer mood1 = new MoodAnalyzer(message1);
//mood1.Analyzer();

//string message2 = "I am in sad mood";
//MoodAnalyzer mood2 = new MoodAnalyzer(message2);
//mood2.Analyzer();

Console.WriteLine("Enter your mood :");

string message = Console.ReadLine();

MoodAnalyzer mood = new MoodAnalyzer(message);
mood.Analyzer();
