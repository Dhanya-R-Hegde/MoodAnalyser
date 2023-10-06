using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndExceptionHandeling
{
    public class MoodAnalyserExceptions : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }

        public ExceptionType type;

        public MoodAnalyserExceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        } 
    }
}
