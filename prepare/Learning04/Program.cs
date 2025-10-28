using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Bob", "Science");
        string output = a.GetSummary();
        Console.WriteLine($"{output}");

        MathAssignent b = new MathAssignent("Bob", "Math", "Chapter 1", "1-5");
        output = $"{b.GetSummary()}-{b.GetHomeworkList()}";
        Console.WriteLine($"{output}");

        WritingAssignment c = new WritingAssignment("Bob", "European History","The many causes of WW2 By Bob");
        output = $"{c.GetWritingInformation()}-{c.GetSummary()}";
        Console.WriteLine($"{output}");
        
    }
}