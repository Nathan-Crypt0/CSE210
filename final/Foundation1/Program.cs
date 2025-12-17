class Program
{
    static void Main(string[] args)
    {
        
        Video v1 = new Video();
        v1.Title = "How to Build a LEGO Starfighter";
        v1.Author = "BrickMaster";
        v1.LengthInSeconds = 480;
        v1.Comments.Add(new Comment("Luke", "Awesome build!"));
        v1.Comments.Add(new Comment("Han", "Looks fast."));
        v1.Comments.Add(new Comment("Leia", "So cool!"));

        Video v2 = new Video();
        v2.Title = "C# Basics Tutorial";
        v2.Author = "TechTeach";
        v2.LengthInSeconds = 600;
        v2.Comments.Add(new Comment("Alice", "Very helpful!"));
        v2.Comments.Add(new Comment("Bob", "Learning a lot."));
        v2.Comments.Add(new Comment("Charlie", "Thanks!"));

        Video v3 = new Video();
        v3.Title = "Trying Weird Snacks";
        v3.Author = "FoodFun";
        v3.LengthInSeconds = 750;
        v3.Comments.Add(new Comment("Sam", "That looked gross."));
        v3.Comments.Add(new Comment("Max", "I'd try it!"));
        v3.Comments.Add(new Comment("Jen", "Funny video!"));

        
        List<Video> videos = new List<Video>() { v1, v2, v3 };

        
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine($"  {c.CommenterName}: {c.Text}");
            }

            Console.WriteLine("-----------------------------------------");
        }
    }
}