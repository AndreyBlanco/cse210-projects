public class Task
{
    private string _title;
    private string _description;
    private string _date;
    private string _notes = "None";
    private string _evaluation = "None";
    private Periods _period;
    
    public Task(string title, string description, string date, Periods period)
    {
        _title = title;
        _description = description;
        _date = date;
        _period = period;   
    }

    public Task(string title, string description, string date, string notes, string evaluation, Periods period)
    {
        _title = title;
        _description = description;
        _date = date;
        _notes = notes;
        _evaluation = evaluation;
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

    public void SetPeriod(Periods period)
    {
        _period = period;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDateTime()
    {
        return _date;
    }

    public string GetNotes()
    {
        return _notes;
    }

    public string GetEvaluation()
    {
        return _evaluation;
    }

    public Periods GetPeriod()
    {
        return _period;
    }

    public int GetDates()
    {
        return _period.NumOtDates();
    }
    
    public virtual void DisplayContent()
    {}

    public void EditTask(int accIndex)
    {
        _period.EditDate(accIndex-1);
        Console.WriteLine("Progress Recorded");
        Console.Write("Type notes (This action will rewrite the current notes - Type Enter for NO changes):");
        string typed = Console.ReadLine();
        if (typed != "")
        {
            _notes = typed;
        }
        Console.Write("Type evaluation (This action will rewrite the current evaluation - Type Enter for NO changes):");
        typed = Console.ReadLine();
        if (typed != "")
        {
            _evaluation = typed;
        }

        DisplayTask();
    }

    public void DisplayTask()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date Created: {_date}");
        Console.WriteLine($"Notes: {_notes}");
        Console.WriteLine($"Evaluation: {_evaluation}");
        _period.DisplayPeriod();
    }

    public virtual void SaveTask(string filename)
    {}
}