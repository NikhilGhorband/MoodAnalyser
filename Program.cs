namespace MoodAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = "I am in Sad Mood";
            Mood moodAnalyzer1 = new Mood();
            moodAnalyzer1.analyseMood(message);

            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string result1 = moodAnalyser.analyseMood1();

            string result2 = moodAnalyser.msg;
            Console.WriteLine(result1);

            Console.WriteLine(result2);


        }
    }
}