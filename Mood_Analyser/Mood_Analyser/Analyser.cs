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
        public Analyser()
        {

        }
        public Analyser(string message)
        {
            this.message = message;
        }
        public string Mood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionTypes.ENTERED_EMPTY, "Mood should not be Empty");

                }
                if (this.message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionTypes.ENTERED_NULL, "Mood should not be Null");
            }
        }
    }
}
