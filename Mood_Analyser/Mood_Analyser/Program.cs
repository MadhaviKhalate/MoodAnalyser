﻿using System;

namespace Mood_Analyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "";
            Analyser analyse = new Analyser(input);
            analyse.Mood();
        }
    }
}