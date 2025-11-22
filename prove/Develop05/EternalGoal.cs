using System;

namespace EternalQuest
{
    
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points) {}

        public override int RecordEvent()
        {
            return Points; 
        }

        public override bool IsComplete()
        {
            return false; 
        }

        public override string Display()
        {
            return $"[∞] {Name} ({Description})";
        }

        public override string SaveString()
        {
            return $"Eternal|{Name}|{Description}|{Points}";
        }
    }
}
