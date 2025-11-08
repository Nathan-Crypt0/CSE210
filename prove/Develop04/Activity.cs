using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like this session to last? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

// animation
    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }
}
