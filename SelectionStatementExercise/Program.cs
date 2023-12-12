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
            var favNumber = r.Next(1, 10);

            Console.WriteLine("Choose a number between 1 - 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("You are correct. Great Job!!!");
            }
            else if (userInput <= favNumber) 
            {
                Console.WriteLine("Too low, Try again");
             
            }
            else if (userInput >= favNumber) 
            {
                Console.WriteLine("Too High. Try again");
            }

        }
    

    }
}
