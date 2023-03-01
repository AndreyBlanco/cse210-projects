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
            Console.WriteLine("  1. Start breathing ativity");
            Console.WriteLine("  2. Start reflecting ativity");
            Console.WriteLine("  3. Start listing ativity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            endProgram = Console.ReadLine();

            if (endProgram == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "4", "6");
                breathingActivity.RunActivity();
            }
             if (endProgram == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectionActivity.RunActivity();
            }
             if (endProgram == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.RunActivity();
            }
             if (endProgram != "4")
            {
                Console.Clear();
                Console.WriteLine("Please, try again.");
            }
        }
        Console.Clear();
    }
}