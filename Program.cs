namespace MoodAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter mood Happy/Sad : ");
            string M = Console.ReadLine();
            Mood mood = new Mood(M);
            Console.WriteLine(mood.AnalyzeMood());
        }
    }
}