using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        
        public void CreateGoal()
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Eternal");
            Console.WriteLine("3. Checklist");

            string input = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (input == "1")
            {
                _goals.Add(new SimpleGoal(name, desc, points));
            }
            else if (input == "2")
            {
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (input == "3")
            {
                Console.Write("Required completions: ");
                int req = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, req, bonus));
            }
        }

        
        public void RecordEvent()
        {
            Console.WriteLine("Which goal did you complete?");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].Name}");
            }

            int choice = int.Parse(Console.ReadLine()) - 1;
            int gained = _goals[choice].RecordEvent();
            _score += gained;
            Console.WriteLine($"You gained {gained} points!");
        }

        
        public void DisplayGoals()
        {
            foreach (Goal g in _goals)
            {
                Console.WriteLine(g.Display());
            }
            Console.WriteLine($"Total Score: {_score}");
        }

        
        public void Save()
        {
            Console.Write("Enter filename to save: ");
            string file = Console.ReadLine();

            using (StreamWriter output = new StreamWriter(file))
            {
                output.WriteLine(_score);
                foreach (Goal g in _goals)
                {
                    output.WriteLine(g.SaveString());
                }
            }
        }

        
        public void Load()
        {
            Console.Write("Enter filename to load: ");
            string file = Console.ReadLine();

            string[] lines = File.ReadAllLines(file);
            _score = int.Parse(lines[0]);

            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "Simple")
                {
                    SimpleGoal g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) g.RecordEvent();
                    _goals.Add(g);
                }
                else if (type == "Eternal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "Checklist")
                {
                    ChecklistGoal g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    int completed = int.Parse(parts[6]);
                    for (int c = 0; c < completed; c++) g.RecordEvent();
                    _goals.Add(g);
                }
            }
        }
    }
}
