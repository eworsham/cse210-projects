using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Journal class instance
        Journal journal = new Journal();

        // Create PromptGenerator class instance and populate the prompts
        PromptGenerator promptGenerator = new PromptGenerator();
        List<string> prompts = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        ];
        promptGenerator._prompts = prompts;

        // Introduction
        Console.WriteLine();
        Console.WriteLine("Welcome to your Journal!!!");

        // Menu loop
        int userChoice = 0;
        while (userChoice != 5)
        {
            showMenu();
            
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) // Write a new entry
            {
                // Get a random prompt
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine();
                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("> ");

                // Get the users entry
                string usersEntry = Console.ReadLine();

                // Get the date for the entry
                // FIXME
                
                // Save new entry to the journal
                Entry entry = new Entry();
                entry._promptText = randomPrompt;
                entry._entryText = usersEntry;

                // FIX ME
                entry.Display();


            }
            else if (userChoice == 2) // Display the journal
            {

            }
            else if (userChoice == 3) // Load the journal from a file
            {

            }
            else if (userChoice == 4) // Save the journal to a file
            {

            }
            else if (userChoice == 5) // Quit the promgram
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    public static void showMenu() 
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    
}