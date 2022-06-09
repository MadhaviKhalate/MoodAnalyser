﻿using System;
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
                throw new CustomException(CustomException.ExceptionTypes.NO_SUCH_METHOD, "Constructor Not Found");
            }
        }

        public static object MoodAnalyserUsingParamaterisedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(Analyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new[] { message });
                    return instance;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionTypes.NO_SUCH_METHOD, "Constructor Not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionTypes.NO_SUCH_CLASS, "Class Not Found");
            }
        }
        public static object InvokeMoodAnalyser(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("Mood_Analyser.Analyser");
                object moodAnalyserObject = MoodAnalyserFactory.MoodAnalyserUsingParamaterisedConstructor("Mood_Analyser.Analyser", "Analyser", message);
                MethodInfo analyseMethodInfo = type.GetMethod(methodName);
                object mood = analyseMethodInfo.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionTypes.NO_SUCH_METHOD, "Method is Not Found");
            }
        }
    }
}
