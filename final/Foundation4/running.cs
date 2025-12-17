using System;

namespace FitnessTracker
{
    public class Running : Activity
    {
        private double distance; 

        public double Distance { get { return distance; } set { distance = value; } }

        public Running(string date, double lengthInMinutes, double distance)
            : base(date, lengthInMinutes)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return (distance / LengthInMinutes) * 60;
        }
    }

    public class Cycling : Activity
    {
        private double speed; 

        public double Speed { get { return speed; } set { speed = value; } }

        public Cycling(string date, double lengthInMinutes, double speed)
            : base(date, lengthInMinutes)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return (speed * LengthInMinutes) / 60.0;
        }

        public override double GetSpeed()
        {
            return speed;
        }
    }

    public class Swimming : Activity
    {
        private int laps;

        public int Laps { get { return laps; } set { laps = value; } }

        public Swimming(string date, double lengthInMinutes, int laps)
            : base(date, lengthInMinutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50.0 / 1000.0; 
        }

        public override double GetSpeed()
        {
            return (GetDistance() / LengthInMinutes) * 60;
        }
    }
}
