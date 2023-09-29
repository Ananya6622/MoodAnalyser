using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public String Message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            this.Message = message;
        }

        public String AnalyseMood()
        {
            try
            {
                if (this.Message.Equals(string.Empty))
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESAGE, "mood should not be empty");
                if (this.Message.ToLower().Contains("sad"))
                    return "SAD";
                else return "HAPPY";
            }
            catch
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESAGE, "mood should not be empty");
            }
          

        }
    }
}
