using System.Collections.Generic;

public class PromptGenerator
{
    string prompt1 = "Who was the most interesting person I interacted with today?";
    string prompt2 = "What was the best part of my day?";
    string prompt3 = "How did I see the hand of the Lord in my life today?";
    string prompt4 = "What was the strongest emotion I felt today?";
    string prompt5 = "If I had one thing I could do over today, what would it be?"; 
    
    public string randomPrompt()
    {
        List<string> _promptList = new List<string>();
        
        _promptList.Add(prompt1);
        _promptList.Add(prompt2);
        _promptList.Add(prompt3);
        _promptList.Add(prompt4);
        _promptList.Add(prompt5);
        
        Random r = new Random();

        int i = r.Next (0, 5);

        return _promptList[i];
    }

}