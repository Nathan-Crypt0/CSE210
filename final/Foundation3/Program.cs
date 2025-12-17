using System;

namespace EventPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Address lectureAddress = new Address("123 Main St", "Springfield", "IL", "USA");
            Lecture lecture = new Lecture("Tech Talk", "Learn about AI", "2025-12-20", "10:00 AM", lectureAddress, "Dr. Smith", 100);

            Address receptionAddress = new Address("456 Oak Ave", "Metropolis", "NY", "USA");
            Reception reception = new Reception("Networking Evening", "Meet professionals", "2025-12-22", "6:00 PM", receptionAddress, "rsvp@example.com");

            Address outdoorAddress = new Address("789 Park Rd", "Sunnyvale", "CA", "USA");
            OutdoorGathering outdoor = new OutdoorGathering("Picnic in the Park", "Family fun day", "2025-12-25", "12:00 PM", outdoorAddress, "Sunny, 75°F");

            Event[] events = { lecture, reception, outdoor };

            foreach (Event ev in events)
            {
                Console.WriteLine("----- STANDARD DETAILS -----");
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine("\n----- FULL DETAILS -----");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine("\n----- SHORT DESCRIPTION -----");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine("\n==============================\n");
            }
        }
    }
}
