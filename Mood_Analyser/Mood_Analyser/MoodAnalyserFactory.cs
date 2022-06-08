using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Mood_Analyser
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className,string constructorName)
        {
            string pattern = @"^" + constructorName + "$";
            Match result = Regex.Match(pattern, className);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionTypes.NO_SUCH_METHOD, "Class Not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionTypes.NO_SUCH_METHOD, "Constructor is Not Found");
            }
        }
    }
}
