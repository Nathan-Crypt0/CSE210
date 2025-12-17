using System;

namespace FitnessTracker
{
    public abstract class Activity
    {
        private string date;
        private double lengthInMinutes;

        public string Date { get { return date; } set { date = value; } }
        public double LengthInMinutes { get { return lengthInMinutes; } set { lengthInMinutes = value; } }

        public Activity(string date, double lengthInMinutes)
        {
            this.date = date;
            this.lengthInMinutes = lengthInMinutes;
        }

        
        public abstract double GetDistance(); 
        public abstract double GetSpeed();    
        public double GetPace()                
        {
            double distance = GetDistance();
            return distance > 0 ? lengthInMinutes / distance : 0;
        }

        public virtual string GetSummary()
        {
            return $"{Date} {this.GetType().Name} ({LengthInMinutes} min) - Distance: {GetDistance():0.0} km, " +
                   $"Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.2} min/km";
        }
    }
}
