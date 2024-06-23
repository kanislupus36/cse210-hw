using System;
using System.Collections.Generic;
using System.IO;

public class Journal()
{
    public List<Entry> _entries = new List<Entry>();

    // method that adds the entries to the journal which is a list.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // method that displays the entries in the journal.
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // method that saves the journal to a file.
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._promptText}|{entry._entryText}|{entry._date}|{entry._gratitude}");
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while saving the journal: {e.Message}");
        }
    }

    // method that loads the journal from a file.
    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear(); // Clear existing entries
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string prompt = parts[0];
                        string response = parts[1];
                        string date = parts[2];
                        string gratitude = parts[3];
                        _entries.Add(new Entry(prompt, response, date, gratitude));
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while loading the journal: {e.Message}");
        }
    }
    }
