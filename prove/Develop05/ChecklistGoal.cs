using System;

namespace EternalQuest
{
    
    public class ChecklistGoal : Goal
    {
        private int _required;
        private int _completed;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int required, int bonus)
            : base(name, description, points)
        {
            _required = required;
            _bonus = bonus;
            _completed = 0;
        }

        public override int RecordEvent()
        {
            _completed++;
            if (_completed == _required)
            {
                return Points + _bonus; 
            }
            return Points;
        }

        public override bool IsComplete()
        {
            return _completed >= _required;
        }

        public override string Display()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {Name} ({Description}) -- Completed {_completed}/{_required}";
        }

        public override string SaveString()
        {
            return $"Checklist|{Name}|{Description}|{Points}|{_required}|{_bonus}|{_completed}";
        }
    }
}
