using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyserCustomException: Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESAGE,
            NULL_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            IMPROPER_MESSAGE,
            NO_SUCH_FIELD
        }
        public readonly ExceptionType Type; 

        public MoodAnalyserCustomException(ExceptionType type,String message) : base(message)
        {
            this.Type = type;
        }
    }
}
