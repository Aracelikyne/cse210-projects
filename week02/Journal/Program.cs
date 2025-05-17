using System;

class Program
{
    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
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
                Entry entry = new Entry();
                string prompt = promptGenerator.GetRandomPrompt();
                entry._promptText = prompt;
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
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine($"Entries saved to {filename}");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine($"Entries loaded from {filename}");
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