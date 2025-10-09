using System;

class Program
{
    static void Main(string[] args)
    {
         Random random = new Random();
        int magicNumber = random.Next("Welcome to your private journal.", "Whats on your mind today?", "Get your typing fingers on.");
    }
}