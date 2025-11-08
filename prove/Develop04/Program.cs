using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the mindfulness opportunities app!");
            Console.WriteLine("Choose one of the following:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("You chose option 1.");
                Breathing activity = new Breathing();
                activity.Run();
            }
            else if (input == "2")
            {
                Console.WriteLine("You chose option 2.");
                Listing activity = new Listing();
                activity.Run();
            }
            else if (input == "3")
            {
                Console.WriteLine("You chose option 3.");
                Reflection activity = new Reflection();
                activity.Run();
                
            }
            else if (input == "4")
            {
                Console.WriteLine("Goodbye.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.\n");
            }
        }
    }
}

