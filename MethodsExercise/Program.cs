namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateStory();
        }

        static string Question(string text)
        {
            // Write() instead of WriteLine() to allow
            // same line reply. ReadLine provides a new line
            // after input.
            Console.Write(text);
            return Console.ReadLine();
        }

        static void CreateStory()
        {
            string userName = Question("What is your name: ");
            string color = Question("What is your favorite color: ");
            string animal = Question("What is your favorite animal: ");
            string band = Question("What is your favorite band: ");

            Console.WriteLine($"Your name is {userName}.\n"
                + $"Your favorite color is {color}.\n"
                + $"Your favorite animal is {animal}.\n"
                + $"Your favorite band is {band}.");
        }
    }
}
