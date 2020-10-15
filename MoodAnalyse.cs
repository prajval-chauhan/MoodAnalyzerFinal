using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerFinal
{
    public class MoodAnalyse
    {
        public string AnalyseMessage(string message)
        {
            string messageConverted = message.ToLower();
            if (messageConverted.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
