using System;

namespace EventPlanner
{
    
    public abstract class Event
    {
        private string title;
        private string description;
        private string date;
        private string time;
        private Address address;

        public string Title { get { return title; } set { title = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string Time { get { return time; } set { time = value; } }
        public Address EventAddress { get { return address; } set { address = value; } }

        public Event(string title, string description, string date, string time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetFullAddress()}";
        }

        public abstract string GetFullDetails();

        public virtual string GetShortDescription()
        {
            return $"Type: {this.GetType().Name}, Title: {title}, Date: {date}";
        }
    }

    
    public class Lecture : Event
    {
        private string speaker;
        private int capacity;

        public string Speaker { get { return speaker; } set { speaker = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            this.speaker = speaker;
            this.capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
        }
    }

    
    public class Reception : Event
    {
        private string rsvpEmail;

        public string RsvpEmail { get { return rsvpEmail; } set { rsvpEmail = value; } }

        public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
        }
    }

    
    public class OutdoorGathering : Event
    {
        private string weatherForecast;

        public string WeatherForecast { get { return weatherForecast; } set { weatherForecast = value; } }

        public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            this.weatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {weatherForecast}";
        }
    }
}
