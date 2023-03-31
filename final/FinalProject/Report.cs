public class Report
{
    private Dictionary<string, Task> _reportDict = new Dictionary<string, Task>();

    public Report()
    {}

    public void AddTask(string taskName, Task newTask)
    {
        _reportDict.Add(taskName, newTask);
    }
}