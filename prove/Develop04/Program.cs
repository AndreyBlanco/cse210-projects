using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        string endProgram = "continue";

        while (endProgram != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing ativity")
            Console.WriteLine("  2. Start reflecting ativity")
            Console.WriteLine("  3. Start listing ativity")
            Console.WriteLine("  4. Quit")
            Console.Write("Select a choice from the menu: ")
            endProgram = Console.ReadLine();

            if (endProgram == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
            }
        }
        Console.Clear();
    }
}