﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class Analyser
    {
        public string Mood(string input)
        {
            if (input.ToLower().Contains("sad"))
            {
                return "Sad";
            }
            return "Happy";
        }
    }
}
