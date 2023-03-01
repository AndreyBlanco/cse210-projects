using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _promptList = new List<string>();
    private List<string> _responses = new List<string>();
    
    public ListingActivity()
    {
        SetActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        _promptList.Add("Who are people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some of your personal heroes?");
   }

     public ListingActivity(string activity, string description) : base (activity, description)
    {
        _promptList.Add("Who are people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some of your personal heroes?");
    }

    public ListingActivity(string activity, string description, List<string> promptList) : base (activity, description)
    {
        _promptList = promptList;
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        SetTime();
        
        Console.WriteLine("Get ready...");
        RunSpinner();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine("--- " + RunPrompt() + " ---");
        Console.Write("You may begin in:");
        RunCountdown(4);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTime());
        
        while (DateTime.Now < endTime)
        {
            Responses();
        } 
        
        Console.WriteLine("You listed " + _responses.Count + " items.");
        Console.WriteLine();

        DisplayEndMessage();
    }

    public void Responses()
    {
        Console.Write("> ");
        _responses.Add(Console.ReadLine());
    }

    public string RunPrompt()
    {
        Random rnd = new Random();
        return  _promptList[rnd.Next(5)];
    }
}