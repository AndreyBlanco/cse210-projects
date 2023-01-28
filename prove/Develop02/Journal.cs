using System.Collections.Generic;
using System.IO; 

public class Journal
{
    public string _name = "";
    public List<Entry> _journalList = new List<Entry>();
    
    public void Display()
    {
        foreach (Entry entry in _journalList)
        {
            entry.Display();
            Console.WriteLine();
        }
        
    }

    public void LoadJournal()
    {
        string[] lines = System.IO.File.ReadAllLines(_name);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("*");
            Entry newEntry = new Entry();

            newEntry._date = parts[0];
            newEntry._time = parts[1];
            newEntry._promptSel = parts[2];
            newEntry._userEntry = parts[3];
            _journalList.Add(newEntry);
        }
        
    }

    public void SaveJournal()
    {
        using (StreamWriter outputFile = new StreamWriter(_name))
        {
            foreach (Entry entry in _journalList)
            {
                outputFile.WriteLine($"{entry._date}*{entry._time}*{entry._promptSel}*{entry._userEntry}");
            }
        }
        
    }
}