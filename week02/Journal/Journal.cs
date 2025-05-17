using System.IO;
using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    DateTime currentTime = DateTime.Now;
    Entry entry1 = new Entry();

    public void AddEntry(Entry entry)
    {
        entry._date = currentTime.ToString("MM/dd/yyyy");
        _entries.Add(entry);

    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }
        Console.WriteLine("All journal entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("End of journal entries.");

    }
    public string GetRandomPrompt()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        return promptGenerator.GetRandomPrompt();
    }
    public void SaveToFile(string filename)
    {
        string filesName = "journal.txt";
        using (StreamWriter writer = new StreamWriter(filesName))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

    }
    public void LoadFromFile(string filename)
    {
        string filesName = "journal.txt";
        if (File.Exists(filesName))
        {
            using (StreamReader reader = new StreamReader(filesName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry();
                        entry._date = parts[0];
                        entry._promptText = parts[1];
                        entry._entryText = parts[2];
                        _entries.Add(entry);
                    }
                }
            }
        }
    }

}