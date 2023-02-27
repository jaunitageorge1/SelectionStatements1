namespace SelectionStatementsExercise1
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            var favNumber = r.Next(1, 3);

            Console.WriteLine("You -- yes, I'm looking at you. Guess my favorite number (between 1-3)!");

            var userInput = int.Parse(Console.ReadLine());


            if (userInput < favNumber)
            {
                Console.WriteLine("Too low!!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You're a wizard!");
            }
        }
    }
}