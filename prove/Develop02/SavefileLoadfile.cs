using System;
using System.IO;

class SaveLoadFile
{
    static void Main()
    {
        string filename = "MyJournalFiles.txt";

        // Write to file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // what i want to save and load here
            outputFile.WriteLine();
            outputFile.WriteLine();
        }

        // Read from file
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            string firstName = parts[0];
            string lastName = parts[1];

            Console.WriteLine($"First name: {firstName}, Last name: {lastName}");
        }
    }
}
