using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please pick a menu option. Enter the number to pick:");
        Console.WriteLine("1. Write to journal.");
        Console.WriteLine("2. Display old entries.");
        Console.WriteLine("3. Save journal to file.");
        Console.WriteLine("4. Load journal from file.");
        Console.WriteLine("5. Quit.");

        string menuChoice = Console.ReadLine();
        int menuAnswer = int.Parse(menuChoice);

        if (menuAnswer == 1)
        {
            Console.WriteLine("Writing to journal.");
        }
        else if (menuAnswer == 2)
        {
            Console.WriteLine("Displaying old entries.");
        }
        else if (menuAnswer == 3)
        {
            Console.WriteLine("Save journal to file.");
        }
        else if (menuAnswer == 4)
        {
            Console.WriteLine("Loading from journal.");
        }
        else if (menuAnswer == 5)
        {
            Console.WriteLine("Qutting.");    
        }
        else
        {
            Console.WriteLine("Invalid choice. Please pick a number between 1 and 5.");
        }

        
    }
}

