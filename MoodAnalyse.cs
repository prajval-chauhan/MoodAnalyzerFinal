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
        public string AnalyseMessage()
        {
            string messageConverted = message.ToLower();
            if (messageConverted.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
