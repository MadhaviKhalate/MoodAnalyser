using System;

namespace Mood_Analyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Mood:");
            string userInput = Console.ReadLine();
            MoodAnalyser analyser = new MoodAnalyser();
            Console.WriteLine("Your Mood: " + analyser.Mood(userInput));
        }
    }
}