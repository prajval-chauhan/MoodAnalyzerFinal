using System;

namespace MoodAnalyzerFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser call = new MoodAnalyser("I am Happy");
            Console.WriteLine("welcome to the mood analyzer program\n");
            Console.WriteLine(call.AnalyseMessage());
        }
    }
}
