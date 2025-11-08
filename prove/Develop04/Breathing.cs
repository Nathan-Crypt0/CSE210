using System;
using System.Threading;

public class Breathing : Activity
{    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
    
        DisplayStartingMessage();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

    
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);

            Console.WriteLine("Now breathe out...");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }


    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
