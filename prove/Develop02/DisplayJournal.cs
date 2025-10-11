using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<string> entries = new List<string>();

    
    public void AddEntry(string entry)
    {
        entries.Add(entry);
    }

    
    public void Display()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    
    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, entries);
        Console.WriteLine("Journal saved!");
    }

    
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries = new List<string>(File.ReadAllLines(filename));
            Console.WriteLine("Journal loaded!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
