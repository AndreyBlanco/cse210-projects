using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("");
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {last}, {name} {last}.");
        Console.WriteLine("");


    }
}