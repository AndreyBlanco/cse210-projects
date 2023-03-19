using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        
        string endProgram = "continue";
        int points = 0;
        GoalsFile goalsFile = new GoalsFile();

        while (endProgram != "7")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Edit Goal");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            endProgram = Console.ReadLine();

            if (endProgram == "1")
            {
                string type = "continue";

                while (type != "1" && type != "2" && type != "3")
                {
                    Console.WriteLine("The type of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    type = Console.ReadLine();
                    
                    if (type == "1")
                    {
                        goalsFile.AddSimpleGoal();
                    }
                    else if (type == "2")
                    {
                        goalsFile.AddEternalGoal();
                    }
                    else if (type == "3")
                    {
                        goalsFile.AddCheckListGoal();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Plese, try again.");
                        Console.WriteLine();
                    }

                }

            }
            else if (endProgram == "2")
            {
                goalsFile.DisplayList();
            }
            else if (endProgram == "3")
            {
                goalsFile.Save();
            }
            else if (endProgram == "4")
            {
                goalsFile.Load();
                points = goalsFile.Score();
            }
            else if (endProgram == "5")
            {
                goalsFile.Event();
                points = goalsFile.Score();
                Console.WriteLine($"You now have {points} points.");
            }
            else if (endProgram == "6")
            {
                goalsFile.Edit();
                points = goalsFile.Score();
            }
             else if (endProgram != "7")
            {
                Console.Clear();
                Console.WriteLine("Please, try again.");
            }
        }
        Console.Clear();
    }
}