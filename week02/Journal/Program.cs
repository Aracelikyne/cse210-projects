using System;

class Program
{
    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Enter your response: ");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                journal.SaveToFile("journal.txt");
            }
            else if (choice == "4")
            {
                journal.LoadFromFile("journal.txt");
            }
            else if (choice == "5")
            {
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}