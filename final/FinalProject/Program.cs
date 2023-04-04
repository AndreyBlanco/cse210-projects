using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine("Welcome to the Task Manager");
        Console.WriteLine();

        string endProgram = "continue";
        Child child = new Child();
        
        while (endProgram != "7")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Task Manager");
            Console.WriteLine("  2. Load Task Manager");
            Console.WriteLine("  3. Save Task Manager");
            Console.WriteLine("  4. Add New Task");
            Console.WriteLine("  5. Display Tasks");
            Console.WriteLine("  6. Register Task Progress");
            Console.WriteLine("  7. Quit");
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
                child.SetName(userName);
                child.SetAge(userAge);
                child.DisplayReport();                    
            }
            else if (endProgram == "2")
            {
                Console.WriteLine("Load Task Manager");
                if (child.GetName() == "")
                {
                    child.LoadTasks();
                }
                else
                {
                    Console.Write("Save the progress first? (Y/N)");
                    string confirm = "S";
                    while (confirm != "Y" && confirm != "N")
                    {
                        confirm = Console.ReadLine().ToUpper();
                        if (confirm == "Y")
                        {
                            child.SaveTasks();
                            Console.WriteLine("File Saved.");
                            Child childToOpen = new Child();
                            childToOpen.LoadTasks();  
                            child = childToOpen; 
                        } else if (confirm == "N")
                        {
                            Child childToOpen = new Child();
                            childToOpen.LoadTasks();  
                            child = childToOpen;
                        }
                        else
                        {
                            Console.Write("Save the progress first? (Y/N)"); 
                        }

                    }
                }                
                Console.WriteLine("File Loaded");
            }
            else if (endProgram == "3")
            {
                if (child.GetName() == "")
                {
                    Console.Clear();
                    Console.WriteLine("You have to create a Task Manger first:");                    
                }
                else
                {
                    child.SaveTasks();
                    Console.WriteLine("File Saved.");
                }
            }
            else if (endProgram == "4")
            {
                if (child.GetName() == "")
                {
                    Console.Clear();
                    Console.WriteLine("You have to create a Task Manger first:");                    
                }
                else
                {    
                    string type = "continue";                
                    while (type != "1" && type != "2" && type != "3" && type != "4" && type != "5")
                    {
                        Console.WriteLine("The type of Tasks are:");
                        Console.WriteLine("  1. School Task");
                        Console.WriteLine("  2. Home Task");
                        Console.WriteLine("  3. Sport Task");
                        Console.WriteLine("  4. Music Task");
                        Console.WriteLine("  5. Church Task");
                        Console.Write("Which type of Task would you like to create? ");
                        type = Console.ReadLine();
                        
                        if (type == "1")
                        {
                            child.AddSchoolTask();
                        }
                        else if (type == "2")
                        {
                            child.AddHomeTask();
                        }
                        else if (type == "3")
                        {
                            child.AddSportTask();
                        }
                        else if (type == "4")
                        {
                            child.AddMusicTask();
                        }
                        else if (type == "5")
                        {
                            child.AddChurchTask();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Plese, try again.");
                            Console.WriteLine();
                        }
                    }
                }

            }
            else if (endProgram == "5")
            {
                if (child.GetName() == "")
                {
                    Console.Clear();
                    Console.WriteLine("You have to create a Task Manger first:");                    
                }
                else
                {
                    child.DisplayTasks();
                }
            }
            else if (endProgram == "6")
            {
                Console.WriteLine("Register Task Progress");
                child.RecordList();
            }
        }
        Console.Clear();
    }
}


