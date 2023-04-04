using System.IO;

public class Child
{
    private string _userName;
    private int _userAge;
    private Report _userRecord = new Report();

    public Child()
    {
        _userName = "";
        _userAge = 0;
    }
    
    public Child(string userName, int userAge)
    {
        _userName = userName;
        _userAge = userAge;
    }

    public void DisplayReport()
    {
        Console.WriteLine($"Name: {_userName}, Age: {_userAge}");
    }

    public void SetName(string userName)
    {
        _userName = userName;
    }

    public string GetName()
    {
        return _userName;
    }

    public void SetAge(int userAge)
    {
        _userAge = userAge;
    }

    public void AddSchoolTask()
    {
        Console.WriteLine("SchoolTask:");

        string taskTitle;
        string taskDescription;
        string subject;
        string datetime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        
        Console.Write("Enter the Task Title: ");
        taskTitle = Console.ReadLine();
        Console.Write("Enter a description: ");
        taskDescription = Console.ReadLine();
        Console.Write("Enter the subject: ");
        subject = Console.ReadLine();

        string type = "continue";                
        while (type != "1" && type != "2" && type != "3")
        {
            Console.WriteLine("Select a period:");
            Console.WriteLine("  1. One Time");
            Console.WriteLine("  2. Daily");
            Console.WriteLine("  3. Weekly");
            Console.Write(" What will be the period of this task?: ");
            type = Console.ReadLine();
                        
            if (type == "1")
            {
                Console.WriteLine("END DATE"); 
                string date = SetDate();  
                OneTimePeriod period = new OneTimePeriod(date);

                SchoolTask newTask = new SchoolTask(taskTitle, taskDescription, datetime, period, subject);
                _userRecord.AddTask(newTask);
            }
            else if (type == "2")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                DailyPeriod period = new DailyPeriod(date1, date2);

                SchoolTask newTask = new SchoolTask(taskTitle, taskDescription, datetime, period, subject);
                _userRecord.AddTask(newTask);
            }
            else if (type == "3")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                WeeklyPeriod period = new WeeklyPeriod(date1, date2);

                SchoolTask newTask = new SchoolTask(taskTitle, taskDescription, datetime, period, subject);
                _userRecord.AddTask(newTask);
            }
            else
            {
                Console.WriteLine("Plese, try again.");
                Console.WriteLine();
            }
        }
    }

    public void AddHomeTask()
    {
        Console.WriteLine("HomeTask:");

        string taskTitle;
        string taskDescription;
        string dependence;
        string datetime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        
        Console.Write("Enter the Task Title: ");
        taskTitle = Console.ReadLine();
        Console.Write("Enter a description: ");
        taskDescription = Console.ReadLine();
        Console.Write("Enter the dependence task: ");
        dependence = Console.ReadLine();

        string type = "continue";                
        while (type != "1" && type != "2" && type != "3")
        {
            Console.WriteLine("Select a period:");
            Console.WriteLine("  1. One Time");
            Console.WriteLine("  2. Daily");
            Console.WriteLine("  3. Weekly");
            Console.Write(" What will be the period of this task?: ");
            type = Console.ReadLine();
                        
            if (type == "1")
            {
                Console.WriteLine("END DATE"); 
                string date = SetDate();  
                OneTimePeriod period = new OneTimePeriod(date);

                HomeTask newTask = new HomeTask(taskTitle, taskDescription, datetime, period, dependence);
                _userRecord.AddTask(newTask);
            }
            else if (type == "2")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                DailyPeriod period = new DailyPeriod(date1, date2);

                HomeTask newTask = new HomeTask(taskTitle, taskDescription, datetime, period, dependence);
                _userRecord.AddTask(newTask);
            }
            else if (type == "3")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                WeeklyPeriod period = new WeeklyPeriod(date1, date2);

                HomeTask newTask = new HomeTask(taskTitle, taskDescription, datetime, period, dependence);
                _userRecord.AddTask(newTask);
            }
            else
            {
                Console.WriteLine("Plese, try again.");
                Console.WriteLine();
            }
        }
    }

    public void AddSportTask()
    {
        Console.WriteLine("SportTask:");

        string taskTitle;
        string taskDescription;
        string discipline;
        string datetime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        
        Console.Write("Enter the Task Title: ");
        taskTitle = Console.ReadLine();
        Console.Write("Enter a description: ");
        taskDescription = Console.ReadLine();
        Console.Write("Enter the discipline: ");
        discipline = Console.ReadLine();

        string type = "continue";                
        while (type != "1" && type != "2" && type != "3")
        {
            Console.WriteLine("Select a period:");
            Console.WriteLine("  1. One Time");
            Console.WriteLine("  2. Daily");
            Console.WriteLine("  3. Weekly");
            Console.Write(" What will be the period of this task?: ");
            type = Console.ReadLine();
                        
            if (type == "1")
            {
                Console.WriteLine("END DATE"); 
                string date = SetDate();  
                OneTimePeriod period = new OneTimePeriod(date);

                SportTask newTask = new SportTask(taskTitle, taskDescription, datetime, period, discipline);
                _userRecord.AddTask(newTask);
            }
            else if (type == "2")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                DailyPeriod period = new DailyPeriod(date1, date2);

                SportTask newTask = new SportTask(taskTitle, taskDescription, datetime, period, discipline);
                _userRecord.AddTask(newTask);
            }
            else if (type == "3")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                WeeklyPeriod period = new WeeklyPeriod(date1, date2);

                SportTask newTask = new SportTask(taskTitle, taskDescription, datetime, period, discipline);
                _userRecord.AddTask(newTask);
            }
            else
            {
                Console.WriteLine("Plese, try again.");
                Console.WriteLine();
            }
        }
    }

    public void AddMusicTask()
    {
        Console.WriteLine("MusicTask:");

        string taskTitle;
        string taskDescription;
        string instrument;
        string datetime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        
        Console.Write("Enter the Task Title: ");
        taskTitle = Console.ReadLine();
        Console.Write("Enter a description: ");
        taskDescription = Console.ReadLine();
        Console.Write("Enter the instrument: ");
        instrument = Console.ReadLine();

        string type = "continue";                
        while (type != "1" && type != "2" && type != "3")
        {
            Console.WriteLine("Select a period:");
            Console.WriteLine("  1. One Time");
            Console.WriteLine("  2. Daily");
            Console.WriteLine("  3. Weekly");
            Console.Write(" What will be the period of this task?: ");
            type = Console.ReadLine();
                        
            if (type == "1")
            {
                Console.WriteLine("END DATE"); 
                string date = SetDate();  
                OneTimePeriod period = new OneTimePeriod(date);

                MusicTask newTask = new MusicTask(taskTitle, taskDescription, datetime, period, instrument);
                _userRecord.AddTask(newTask);
            }
            else if (type == "2")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                DailyPeriod period = new DailyPeriod(date1, date2);

                MusicTask newTask = new MusicTask(taskTitle, taskDescription, datetime, period, instrument);
                _userRecord.AddTask(newTask);
            }
            else if (type == "3")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                WeeklyPeriod period = new WeeklyPeriod(date1, date2);

                MusicTask newTask = new MusicTask(taskTitle, taskDescription, datetime, period, instrument);
                _userRecord.AddTask(newTask);
            }
            else
            {
                Console.WriteLine("Plese, try again.");
                Console.WriteLine();
            }
        }
    }

    public void AddChurchTask()
    {
        Console.WriteLine("ChurchTask:");

        string taskTitle;
        string taskDescription;
        string area;
        string datetime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        
        Console.Write("Enter the Task Title: ");
        taskTitle = Console.ReadLine();
        Console.Write("Enter a description: ");
        taskDescription = Console.ReadLine();
        Console.Write("Enter the area: ");
        area = Console.ReadLine();

        string type = "continue";                
        while (type != "1" && type != "2" && type != "3")
        {
            Console.WriteLine("Select a period:");
            Console.WriteLine("  1. One Time");
            Console.WriteLine("  2. Daily");
            Console.WriteLine("  3. Weekly");
            Console.Write(" What will be the period of this task?: ");
            type = Console.ReadLine();
                        
            if (type == "1")
            {
                Console.WriteLine("END DATE"); 
                string date = SetDate();  
                OneTimePeriod period = new OneTimePeriod(date);

                ChurchTask newTask = new ChurchTask(taskTitle, taskDescription, datetime, period, area);
                _userRecord.AddTask(newTask);
            }
            else if (type == "2")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                DailyPeriod period = new DailyPeriod(date1, date2);

                ChurchTask newTask = new ChurchTask(taskTitle, taskDescription, datetime, period, area);
                _userRecord.AddTask(newTask);
            }
            else if (type == "3")
            {
                Console.WriteLine("START DATE"); 
                string date1 = SetDate();
                Console.WriteLine("END DATE"); 
                string date2 = SetDate();  
                WeeklyPeriod period = new WeeklyPeriod(date1, date2);

                ChurchTask newTask = new ChurchTask(taskTitle, taskDescription, datetime, period, area);
                _userRecord.AddTask(newTask);
            }
            else
            {
                Console.WriteLine("Plese, try again.");
                Console.WriteLine();
            }
        }
    }

    public void DisplayTasks()
    {
        Console.WriteLine($"Name: {_userName}");
        _userRecord.DisplayRecord();
    }

    public void SaveTasks()
    {
        string filename = $"{_userName}.txt";    
        using (StreamWriter outPutFile = new StreamWriter(filename))
        {
            outPutFile.WriteLine(_userName);
            outPutFile.WriteLine(_userAge);
        }
                
        _userRecord.SaveRecord(filename);    
    }

    public void LoadTasks()
    {
        string confirmFile = "N";

        while (confirmFile == "N")
        {
            Console.Write("What is the filename?: ");
            string filename = Console.ReadLine();
        
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filename);
                List<string> linesList = new List<string>();

                foreach (string line in lines)
                {
                    linesList.Add(line);   
                }

                _userName = linesList[0];
                linesList.RemoveAt(0);
                _userAge = int.Parse(linesList[0]);
                linesList.RemoveAt(0);
                int count = 0;
                
                foreach (string line in linesList)
                {
                    string[] parts = line.Split("¬");
                    if (parts[0] == "T")
                    {
                        Periods tempPeriod = new Periods();
                        if (parts[8] == "one")
                        {
                            OneTimePeriod period = new OneTimePeriod(parts[10]);
                            string[] comp = linesList[count].Split("¬");
                            period.ChangeAccomplish(comp[1], comp[2]);
                            tempPeriod = period;    
                        }
                        else if (parts[8] == "daily")
                        {
                            DailyPeriod period = new DailyPeriod(parts[9], parts[10]);
                            int sesions = period.GetSesions();
                            for (int i = 1; i < sesions + 1; i++)
                            {
                                string[] comp = linesList[count+i].Split("¬");
                                period.ChangeAccomplish(comp[1], comp[2]);
                            }
                            tempPeriod = period;    
                        }
                        else if (parts[8] == "weekly")
                        {
                            WeeklyPeriod period = new WeeklyPeriod(parts[9], parts[10]);
                            int sesions = period.GetSesions();
                            for (int i = 1; i == sesions; i++)
                            {
                                string[] comp = linesList[count+i].Split("¬");
                                period.ChangeAccomplish(comp[1], comp[2]);
                            }
                            tempPeriod = period;    
                        }

                        if (parts[1] == "School")
                        {
                            SchoolTask task = new SchoolTask(parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], tempPeriod);
                            _userRecord.AddTask(task);
                        }
                        else if (parts[1] == "Home")
                        {
                            HomeTask task = new HomeTask(parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], tempPeriod);
                            _userRecord.AddTask(task);
                        }
                        else if (parts[1] == "Sport")
                        {
                            SportTask task = new SportTask(parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], tempPeriod);
                            _userRecord.AddTask(task);
                        }
                        else if (parts[1] == "Music")
                        {
                            MusicTask task = new MusicTask(parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], tempPeriod);
                            _userRecord.AddTask(task);
                        }
                        else if (parts[1] == "Church")
                        {
                            ChurchTask task = new ChurchTask(parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], tempPeriod);
                            _userRecord.AddTask(task);
                        }
                    }
                    count = count + 1; 
                }
                confirmFile = "Y";
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Incorrect file name or file not found!");
                confirmFile = "N";
            }
        }
    }

    public void RecordList()
    {
        Console.Clear();
        Console.WriteLine($"The Active Tasks List for {_userName} is:");
        _userRecord.TaskList();
        int numberOfTasks = _userRecord.NumOfTasks();
        Console.Write("Which task do you want to record progress for?: ");
        string verif = "Y";
        int taskIndex = 0;

        while (taskIndex < 1 || taskIndex > numberOfTasks)
        {
            while (verif == "Y")
            {
                try
                {
                    taskIndex = int.Parse(Console.ReadLine());
                    verif = "N";
                }
                catch (System.FormatException)
                {
                    Console.Write($"Type a number between 1 and {numberOfTasks}:");
                        verif = "Y";
                    }
            }            
        }

        _userRecord.DisplayUnique(taskIndex); 
    }

    static string SetDate()
    {
        bool test = false;
        string dateTested = "";
        while (test == false)
        {
            Console.Write("Enter the date (d/m/yyyy): ");
            dateTested = Console.ReadLine();
            DateTime outConvert;
            test = DateTime.TryParse(dateTested, out outConvert);
            if (test== false)
            {
                Console.WriteLine("Please, verify the date format and try again:");
            }
        }        
        
        return dateTested;
    }
}