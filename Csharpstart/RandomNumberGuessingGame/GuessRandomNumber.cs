using System;

namespace RandomNumberGuessingGame
{
    class GuessRandomNumber
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double returnValue = random.Next(1, 100);
            int Guess = 0;
            string guessStr = "";
            int attempts = 1;


            Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");
            guessStr = Console.ReadLine();
            Guess = Convert.ToInt32(guessStr);

            while (Guess != returnValue)
            {
                while (Guess < returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess what it is?");
                    guessStr = Console.ReadLine();
                    Guess = Convert.ToInt32(guessStr);
                    attempts++;
                }
                while (Guess > returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess what it is");
                    guessStr = Console.ReadLine();
                    Guess = Convert.ToInt32(guessStr);
                    attempts++;
                }
            }

            Console.WriteLine("Well done! The answer was " + returnValue + ". It took you " + attempts.ToString() + " attempts.");
        }
    }
}
