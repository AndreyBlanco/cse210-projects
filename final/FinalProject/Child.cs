public class Child
{
    private string _userName;
    private int _userAge;
    private Report _userRecord;

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
        string taskName;
        string taskDescription;

        Console.Clear();
        Console.WriteLine("SchoolTask:");
        Console.Write("Enter the Task Name: ");
        taskName = Console.ReadLine();
        Console.Write("Enter a description: ");
        taskDescription = Console.ReadLine();

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
                bool test = false;
                string date = "";

                while (test == false)
                {
                    Console.Write("Enter the date to finish the task (d/m/yyyy): ");
                    date = Console.ReadLine();
                    test = testDate(date);
                    if (test== false)
                    {
                        Console.WriteLine("Please, verify the date format and try again:");
                    }
                }

                OneTimePeriod period = new OneTimePeriod(date);
            }
            /*else if (type == "2")
            {
                Child.AddHomeTask();
            }
            else if (type == "3")
            {
                Child.AddSportTask();
            }
            else
            {
                Console.WriteLine("Plese, try again.");
                Console.WriteLine();
            }*/
        }
    }

    static bool testDate(string dateToTest)
    {
        DateTime outConvert;
        bool isDate = DateTime.TryParse(dateToTest, out outConvert);
        return isDate;
    }
}