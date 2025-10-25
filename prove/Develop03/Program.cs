using System;

public class Program
{
    private static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.AllHidden())
            {
                scripture.Display();
                Console.WriteLine("All words are hidden.");
                break;
            }
        }
    }
}
