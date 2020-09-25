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
            int numberOfFlips;

            Console.Write("Guess which will have more: heads or tails?");

            headsOrTailsGuess = Console.ReadLine();

            Console.Write("How many times shall we flip a coin?");

            numberOfFlips = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{headsOrTailsGuess} , {numberOfFlips}");


            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,4:N0}", rand.Next(1, 3));
            Console.WriteLine();
        }
    }
}
