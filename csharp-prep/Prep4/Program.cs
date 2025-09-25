using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // List
        List<int> numbers = new List<int>();


        // Do-While Loop
        int userNumber = -1;
        while (userNumber != 0)
        {
            // Gets User Input
            Console.Write("Please enter a number. Entering 0 will end the program");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)

        // adds the numbers
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // averages the numbers
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        


        

    }
}