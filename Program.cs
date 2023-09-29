// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace MoodAnalyserDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the mood analyser problem. \n");

            string message = "I am in a sad Mood";
            MoodAnalyser Mood1 = new MoodAnalyser(message);
            Console.WriteLine("Given message is: " + message);
            Console.WriteLine("The returned value is: " + Mood1.AnalyseMood());

            //string message = "I am in a Happy Mood";
            //MoodAnalyser Mood2 = new MoodAnalyser(I am in a Happy Mood);
            //Console.WriteLine("Given message is: " + message);
            //Console.WriteLine("The returned value is: " + Mood2.AnalyseMood());
        }
    }
}