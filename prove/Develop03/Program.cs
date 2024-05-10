/*
Scripture Memorizer Program
By Ryan Worsham

Exceeding Requirements:

I made 2 additional improvements to my program that showed creativity and exceeded requirements.

    1.	I improved the process of picking random words to hide so that the program will pick from
        words that have not already been hidden instead of hiding a word that was previously hidden

    2.	


*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create reference object
        string book = "Proverbs";
        int chapter = 3;
        int startVerse = 5;
        int endVerse = 6;
        Reference reference = new Reference(book, chapter, startVerse, endVerse);

        // Create scripture object
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";
        while (userInput != "quit")
        {
            // Write scripture to console
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt for user input
            Console.WriteLine();
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            // Hide random words
            scripture.HideRandomWords(3);
        }
    }
}