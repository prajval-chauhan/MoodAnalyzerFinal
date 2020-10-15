using System;
using System.Collections.Generic;
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
                string messageConverted = message.ToLower();
                if (messageConverted.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
