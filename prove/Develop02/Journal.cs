using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void NewEntry()
    {
        string prompt = Entry.GeneratePrompt();
        Console.WriteLine(prompt);
        string answer = Console.ReadLine();

        Entry entry = new Entry(answer, prompt, DateTime.Now);
        entries.Add(entry);
        Console.WriteLine();
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date.ToString("yyyy-MM-dd")}|{entry.Prompt}|{entry.UserEntry}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                DateTime date = DateTime.ParseExact(parts[0], "yyyy-MM-dd", null);
                string prompt = parts[1];
                string userEntry = parts[2];
                entries.Add(new Entry(userEntry, prompt, date));
            }
        }
    }
}
