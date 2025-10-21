using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the scripture memorizer program.");
            Console.WriteLine("\nmenu:");
            Console.WriteLine("1. Begin");
            Console.WriteLine("2. Quit");
            string choice = Console.ReadLine();

            if (choice == "1")
            { }

            else if (choice == "2")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            else 
            Console.WriteLine("Invalid choice. Please pick 1-2.");
        }
    }
}