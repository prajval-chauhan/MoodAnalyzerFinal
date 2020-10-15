using System;

namespace MoodAnalyzerFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyse call = new MoodAnalyse();
            Console.WriteLine("Welcome to the Mood Analyzer Program\n");
            Console.WriteLine(call.AnalyseMessage("I am Happy"));
            Console.WriteLine(call.AnalyseMessage("I am not feeling anything"));
        }
    }
}
