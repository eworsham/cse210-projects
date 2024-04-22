using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        string userGuessAsText;
        int userGuess = 0;
        while (userGuess != magicNumber) 
        {
            Console.Write("What is your guess? ");
            userGuessAsText = Console.ReadLine();
            userGuess = int.Parse(userGuessAsText);

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You guessed it!");

    }
}