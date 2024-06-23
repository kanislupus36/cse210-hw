using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was something funny that happened today?",
        "What was the weather like today?",
        "Did you go anywhere today?",
        "What was the best thing you ate today?",
        "Did something weird happen today?"

    };
    
    public Random random = new Random();

    // generates a random prompt for the journal entry.
    public string GetRandomPrompt()
    {        
        int getPrompt = random.Next(_prompts.Count);

        return _prompts[getPrompt];
    }
}