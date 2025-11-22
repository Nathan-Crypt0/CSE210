using System;

namespace EternalQuest
{
    
    public class SimpleGoal : Goal
    {
        private bool _complete = false;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points) {}

        public override int RecordEvent()
        {
            if (!_complete)
            {
                _complete = true;
                return Points;
            }
            return 0; 
        }

        public override bool IsComplete()
        {
            return _complete;
        }

        public override string Display()
        {
            return $"[{(_complete ? "X" : " ")}] {Name} ({Description})";
        }

        public override string SaveString()
        {
            return $"Simple|{Name}|{Description}|{Points}|{_complete}";
        }
    }
}
