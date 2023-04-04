public class Report
{
    private List<Task> _reportList = new List<Task>();

    public Report()
    {}

    public void AddTask(Task newTask)
    {
        _reportList.Add(newTask);
    }

    public void Reorder()
    {
        _reportList.Reverse();
    }

    public void DisplayRecord()
    {
        int count = 1;
        foreach (Task currentTask in _reportList)
        {
            Console.WriteLine();
            Console.WriteLine($"Task {count}");
            currentTask.DisplayContent();
            count = count + 1;
        }
    }

    public void DisplayUnique(int taskIndex)
    {
        _reportList[taskIndex - 1].DisplayContent();
        int numOfDates = _reportList[taskIndex - 1].GetDates();

        Console.Write("Which date was completed: ");
        string verif = "Y";
        int accIndex = 0;

        while (accIndex < 1 || accIndex > numOfDates)
        {
            while (verif == "Y")
            {
                try
                {
                    accIndex = int.Parse(Console.ReadLine());
                    verif = "N";
                }
                catch (System.FormatException)
                {
                    Console.Write($"Type a number between 1 and {numOfDates}:");
                        verif = "Y";
                    }
            }            
        }

        _reportList[taskIndex - 1].EditTask(accIndex);
    }

    public void SaveRecord(string filename)
    {
        foreach (Task task in _reportList)
        {
            task.SaveTask(filename);
        } 
    }

    public void TaskList()
    {
        int count = 1;
        foreach (Task item in _reportList)
        {
            Console.WriteLine($"{count}.   {item.GetTitle()} - {item.GetDescription()}");
            count = count + 1;    
        }
    }
    
    public int NumOfTasks()
    {
        return _reportList.Count;
    }
}