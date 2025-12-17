using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running("03 Nov 2022", 30, 5)); 
            activities.Add(new Cycling("04 Nov 2022", 45, 20)); 
            activities.Add(new Swimming("05 Nov 2022", 60, 40)); 

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}

