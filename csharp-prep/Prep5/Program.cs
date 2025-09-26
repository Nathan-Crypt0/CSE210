using System;

class Program
{
    static void Main(string[] args)
    {
        //  Display welcome message
        DisplayWelcome();

        //  Ask for user info
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        //  Ask for birth year using an out parameter
        int birthYear;
        PromptUserBirthYear(out birthYear);

        //  Square the favorite number
        int squaredNumber = SquareNumber(favoriteNumber);

        //  Display the result
        DisplayResult(name, squaredNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"\nHello {name}!");
        Console.WriteLine($"Your favorite number squared is: {squaredNumber}");
        Console.WriteLine($"You will turn {age} years old this year.");
    }
}
