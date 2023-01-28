using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        
        string selector = "0";
        Journal _myJournal = new Journal();
        _myJournal._name = "unsaved";

        while (selector != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            selector = Console.ReadLine();
            PromptGenerator _randomPrompt = new PromptGenerator();
            string _promptSelected = "";
            DateTime theCurrentTime = DateTime.Now;
            string currentDate = theCurrentTime.ToShortDateString();
            string currentTime = theCurrentTime.ToString("hh:mm tt");


            if (selector == "1")
            {
                Console.WriteLine("You selected 1. Write");
                _promptSelected = _randomPrompt.randomPrompt();
                Console.WriteLine(_promptSelected);
                Entry _newEntry = new Entry();
                _newEntry._date = currentDate;
                _newEntry._time = currentTime;
                _newEntry._promptSel = _promptSelected;
                _newEntry._userEntry = Console.ReadLine();
                _myJournal._journalList.Add(_newEntry);
            }
            else if (selector == "2")
            {
                Console.WriteLine("You selected 2. Display");
                _myJournal.Display();
            }
            else if (selector == "3")
            {
                Console.WriteLine("You selected 3. Load");
                Console.WriteLine("What is the filename?: ");
                _myJournal._name = Console.ReadLine();
                _myJournal.LoadJournal();
            }
            else if (selector == "4")
            {
                Console.WriteLine("You selected 4. Save");
                Console.WriteLine("What is the filename?: ");
                _myJournal._name = Console.ReadLine();
                _myJournal.SaveJournal();
            }
            else if (selector == "5")
            {
                Console.WriteLine("You selected 5. Quit");
            }
            else
            {
                Console.WriteLine("Please try again");
            }

        }
        
    }
}