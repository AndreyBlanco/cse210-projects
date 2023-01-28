using System.Collections.Generic;

public class Entry
{
    public string _date = "";
    public string _time = "";
    public string _promptSel = "";
    public string _userEntry = "";
    public List<string> _newEntry = new List<string>();
    
    public void Display()
    {
        Console.WriteLine($"Date and Time: {_date} {_time} - Prompt: {_promptSel}");
        Console.WriteLine($"{_userEntry}");
    }



}