namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateStory();

            DoMath();
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

        static int Add(params int[] values)
        {
            int total = values[0];

            foreach (int value in values.Skip(1))
                total += value;

            return total;
        }

        static int Subtract(params int[] values)
        {
            int total = values[0];

            foreach (int value in values.Skip(1))
                total -= value;

            return total;
        }

        static int Multiply(params int[] values)
        {
            int total = values[0];

            foreach (int value in values.Skip(1))
                total *= value;

            return total;
        }

        static int Divide(params int[] values)
        {
            int total = values[0];

            foreach (int value in values.Skip(1))
                total /= value;

            return total;
        }

        static void DoMath()
        {
            Console.WriteLine("2 + 4 + 6 = " + Add(2, 4, 6).ToString());
            Console.WriteLine("2 - 4 - 1 = " + Subtract(2, 4, 1).ToString());
            Console.WriteLine("2 * 4 * 3 = " + Multiply(2, 4, 3).ToString());
            Console.WriteLine("8 / 2 / 2 = " + Divide(8, 2, 2).ToString());
        }
    }
}
