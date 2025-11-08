using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing()
        : base("Listing",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
       
        DisplayStartingMessage();

        int duration = GetDuration();

       
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nYou will begin in:");
        ShowCountdown(5); 

        Console.WriteLine("\nStart listing items! (Press Enter after each one)\n");

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = ReadLineWithTimeout(endTime);
            if (item == null)
            {
                
                break;
            }
            if (!string.IsNullOrWhiteSpace(item))
            {
                responses.Add(item);
            }
        }

        Console.WriteLine($"\nTime’s up! You listed {responses.Count} items.");
        DisplayEndingMessage();
    }

    
    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }

    
    private string ReadLineWithTimeout(DateTime endTime)
    {
        string input = "";
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(intercept: true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return input;
                }
                else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input = input.Substring(0, input.Length - 1);
                    Console.Write("\b \b");
                }
                else
                {
                    input += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
            Thread.Sleep(50);
        }
        Console.WriteLine();
        return null; 
    }
}
