using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine("Welcome to the Task Manager");
        Console.WriteLine();

        string endProgram = "continue";
        
        while (endProgram != "9")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Task Manager");
            Console.WriteLine("  2. Load Task Manager");
            Console.WriteLine("  3. Save Task Manager");
            Console.WriteLine("  4. Add New Task");
            Console.WriteLine("  5. Display Tasks");
            Console.WriteLine("  6. Register Task Progress");
            Console.WriteLine("  7. Edit Task");
            Console.WriteLine("  8. Task Report");
            Console.WriteLine("  9. Quit");
            Console.Write("Select a choice from the menu: ");
            endProgram = Console.ReadLine();
            Console.Clear();

            if (endProgram == "1")
            {
                Console.WriteLine("Create New Task Manager");
                Console.Write("Please type User Name: ");
                string userName = Console.ReadLine();
                string verif = "Y";
                int userAge = 0;
                while (verif == "Y")
                {
                    Console.Write("Please type User Age: ");
                    try
                    {
                        userAge = int.Parse(Console.ReadLine());
                        verif = "N";
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Type a number!");
                        verif = "Y";
                    }
                }  
                Console.WriteLine($"{userName}, {userAge}.");      
            }
            else if (endProgram == "2")
            {
                Console.WriteLine("Load Task Manager");
            }
            else if (endProgram == "3")
            {
                Console.WriteLine("Save Task Manager");
            }
            else if (endProgram == "4")
            {
                Console.WriteLine("Add New Task");
            }
            else if (endProgram == "5")
            {
                Console.WriteLine("Display Tasks");
            }
            else if (endProgram == "6")
            {
                Console.WriteLine("Register Task Progress");
            }
             else if (endProgram == "7")
            {
                Console.WriteLine("Edit Task");
            }
            else if (endProgram == "8")
            {
                Console.WriteLine("Task Report");
            }
        }
        Console.Clear();
    }
}


