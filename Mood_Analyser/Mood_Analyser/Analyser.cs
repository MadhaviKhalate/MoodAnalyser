using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class Analyser
    {
        public string message;
        public Analyser(string message)
        {
            this.message = message;
        }
        public string Mood()
        {
            if (this.message.ToLower().Contains("sad"))
            {
                Console.WriteLine("Your Mood is Sad");
                return "Sad";
            }
            Console.WriteLine("Your Mood is Happy");
            return "Happy";
        }
    }
}
