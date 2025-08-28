namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 88;
            int guess = 0;

            while (guess != favoriteNumber)
            {
                Console.WriteLine("Guess my favorite number!");
                string userInput = (Console.ReadLine());
                int.TryParse(userInput, out guess);

                if (guess == favoriteNumber)
                {
                    Console.WriteLine("You got the favorite number!");
                }
                else if (guess > favoriteNumber)
                {
                    Console.WriteLine("That's too big! Try again!");
                }
                else if (guess < favoriteNumber)
                {
                    Console.WriteLine("That's to small! Try again!");
                }
                else
                    Console.WriteLine("You got my favorite number!");
            }
        }
    }
}
