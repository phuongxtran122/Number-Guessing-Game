using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a new random number obj
            Random r = new Random();
            // assign random number between 0 and 100 to winNum
            int winNum = r.Next(0,100);
            bool isWinner = false;
            // do-while loop, as long as isWinner is false
            do
            {
                Console.WriteLine("Guess number between 0 and 100");
                string userInput = Console.ReadLine();
                // initialize input to -1
                int i = -1;
                try
                {
                    i = int.Parse(userInput);
                    // if input is not in range [0-100], throw error exception
                    if (i < 0 || i>100)
                    {
                        throw new ArgumentException();
                    }
                }
                // if input is not a number or within range [0-100], catch it
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input. Enter a number between 0 and 100");
                    continue;
                }
                // if user input is above the random number
                if (i > winNum)
                {
                    Console.WriteLine("Too high: Guess lower...");
                }
                // if user input is below the random number

                else if (i < winNum)
                {
                    Console.WriteLine("Too low: Guess higher...");
                }
                // if user guesses correctly
                else
                {
                    Console.WriteLine("Winner");
                    isWinner = true;
                }


            } while (isWinner == false);
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
