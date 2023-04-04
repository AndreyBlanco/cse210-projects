public class Accomplish
{
    private string _date;
    private string _status;

    public Accomplish()
    {}

    public Accomplish(string date)
    {
        _date = date;
        _status = "Incomplete";
    }

    public Accomplish(string date, string status)
    {
        _date = date;
        _status = status;
    }

    public string GetTheDate()
    {
        return _date;
    }
    
    public string GetStatus()
    {
        return _status;
    }

    public void SetStatus()
    {
        _status = "Complete";
    }

    public void ChangeStatus(string date, string status)
    {
        if (_date == date)
        {
            _status = status;
        }
    }

    public void DisplayAccomplish()
    {
        Console.WriteLine($"Date: {_date} - Status: {_status}.");
    }
}