using System;
using System.Collections.Generic;

public class SentencePicker
{
    public void PickSentence()
    {
        string[] sentences =
        {
            "What is on your mind today?",
            "Welcome to your private journal.",
            "How are you feeling right now?",
            "Write about something good that happened today.",
            "What do you want to improve this week?",
            "Describe your favorite memory.",
            "What’s something you learned recently?",
            "If you could change one thing about today, what would it be?",
            "Who made you smile today?",
            "What’s a goal you want to work on?"
        };

        Random random = new Random();
        int randomIndex = random.Next(sentences.Length);

        string randomSentence = sentences[randomIndex];
        Console.WriteLine(randomSentence);
    }
}

