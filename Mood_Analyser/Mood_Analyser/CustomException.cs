using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class CustomException : Exception
    {
        public enum ExceptionTypes
        {
            ENTERED_NULL, ENTERED_EMPTY, NO_SUCH_FIELD, 
            NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        ExceptionTypes type;

        public CustomException(ExceptionTypes Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
