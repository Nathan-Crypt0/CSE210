using System;

namespace EternalQuest
{
    public class Program
    {
        public static void Main()
        {
            GoalManager manager = new GoalManager();

            while (true)
            {
                Console.WriteLine("1. Create Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Load");
                Console.WriteLine("6. Quit");

                string input = Console.ReadLine();

                if (input == "1") manager.CreateGoal();
                else if (input == "2") manager.RecordEvent();
                else if (input == "3") manager.DisplayGoals();
                else if (input == "4") manager.Save();
                else if (input == "5") manager.Load();
                else if (input == "6") break;
            }
        }
    }
}
