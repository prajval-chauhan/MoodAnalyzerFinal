using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace MoodAnalyzerFinal
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse()
        {
            //Default Constructor
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyse"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Method to analyse the mood of the given message
        /// </summary>
        /// <returns></returns>
        public string AnalyseMessage()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }

        }
    }
}
