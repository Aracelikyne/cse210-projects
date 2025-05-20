using System.IO;
using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    DateTime currentTime = DateTime.Now;
    

    public void AddEntry(Entry entry)
    {
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
        Console.WriteLine("---------------------");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("End of journal entries.");
        Console.WriteLine("-----------------------");

    }
    
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

    }
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            Console.WriteLine($"Date: {date}, Prompt: {prompt}, Entry: {entry}");
        }

    }
}
