using System;

namespace Mood_Analyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Mood:");
            string input = Console.ReadLine();
            Analyser analys = new Analyser(input);
            analys.Mood();
        }
    }
}