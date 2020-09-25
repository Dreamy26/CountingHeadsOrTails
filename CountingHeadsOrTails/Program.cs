using System;

namespace CountingHeadsOrTails
{
    class Program
    {
        static void Main(string[] args)
        {
            // Will generate a random number, based on argument passed.
            var rand = new Random();

            string headsOrTailsGuess;
            double numberOfFlips;
            int guessToInteger;
            double correctGuesses = 0;


            // req1
            Console.Write("Guess which will have more: heads or tails?");
            // req2
            headsOrTailsGuess = Console.ReadLine();
            // we need to compare the users choice of heads or tails to the random number we will generate, which we can't do as strings, so lets turn their guesses into numbers.
            if (headsOrTailsGuess.ToLower() == "heads")
            {
                guessToInteger = 1;
            }
            // ideally we would use error handling for the choices, but as a fall back we will count any choice that is not heads as though it was tails.  
            else
            {
                guessToInteger = 2;
            }

            Console.Write("How many times shall we flip a coin?");
            //req3
            numberOfFlips = Convert.ToInt32(Console.ReadLine());

            //req4 Loops the correct number of times
            for (int ctr = 0; ctr < numberOfFlips; ctr++)
            {
                // req5 Generates random numbers each time.
                int tempNumber = rand.Next(1, 3);

                // req6 Correctly generates and displays a random heads or tails each time.
                if (tempNumber == 1)
                {
                    Console.WriteLine("Heads");
                }
                else
                {
                    Console.WriteLine("Tails");
                }
                // req7 Adds to ​correctCount​ accurately.
                if (tempNumber == guessToInteger)
                {
                    correctGuesses += 1;   
                }
            }
            // req8 and req9
            Console.WriteLine($"Your guess, {headsOrTailsGuess}, came up {correctGuesses} time(s).");

            // req 10 Hint: this is the number correct divided by total flips; multiply by 100 to show as a percentage).
            Console.WriteLine($"That's {(correctGuesses/numberOfFlips)*100}%.");
         
        }
    }
}

