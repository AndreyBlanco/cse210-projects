public class Task
{
    private string _tName;
    private string _tDescription;
    private string _notes;
    private string _evaluation;
    private Accomplish _accomplish;
    private Periods _period;
    
    public Task(string name, string description)
    {
        _tName = name;
        _tDescription = description;
    }

    public Task(string name, string description, string notes, string evaluation, Accomplish accomplish, Periods period)
    {
        _tName = name;
        _tDescription = description;
        _notes = notes;
        _evaluation = evaluation;
        _accomplish = accomplish;
        _period = period;
    }

    public void SetNotes(string notes)
    {
        _notes = notes;
    }

    public void SetEvaluation(string evaluation)
    {
        _evaluation = evaluation;
    }

    public void SetAccomplish(Accomplish accomplish)
    {
        _accomplish = accomplish;
    }

    public void SetPeriod(Periods period)
    {
        _period = period;
    }

    public void DisplayTask()
    {
        Console.WriteLine($"{_tName}, {_tDescription}");
    }
}