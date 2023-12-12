namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            GuessNumber();
        }

        public static void GuessNumber()
        {
            var r = new Random();
            var favNumber = r.Next(1, 100);

            Console.WriteLine("Choose a number between 1 - 100");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == 37)
            {
                Console.WriteLine("You are correct. Great Job!!!");
            }
            else if (userInput <= 36) 
            {
                Console.WriteLine("Too low, Try again");
             
            }
            else if (userInput >=38) 
            {
                Console.WriteLine("Too High. Try again");
            }

        }
    

    }
}
