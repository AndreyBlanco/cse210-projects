public class Periods
{
    private string _startDate;
    private string _endDate;    
    private List<Accomplish> _accomplish = new List<Accomplish>();

    public Periods()
    {}
    
    public Periods(string startDate, string endDate)
    {
        _startDate = startDate;
        _endDate = endDate;
    }

    public Periods(string startDate, string endDate, List<Accomplish> accomplish)
    {
        _startDate = startDate;
        _endDate = endDate;
        _accomplish = accomplish;
    }

    public virtual void CreateAccomplish(string endDate, string startDate)
    {}

    public virtual string GetType()
    {
        return "Type";
    }

    public string GetStartDate()
    {
        return _startDate;
    }

    public string GetEndDate()
    {
        return _endDate;
    }

    public List<Accomplish> GetList()
    {
        return _accomplish;
    }

    public int NumOtDates()
    {
        return _accomplish.Count;
    }

    public void SetAccomplish(Accomplish accomplish)
    {
        _accomplish.Add(accomplish);
    }

    public void ChangeAccomplish(string date, string status)
    {
        foreach (Accomplish item in _accomplish)
        {
            item.ChangeStatus(date, status);
        }
    }

    public void EditDate(int accIndex)
    {
        string date = _accomplish[accIndex].GetTheDate();
        _accomplish[accIndex].ChangeStatus(date, "Complete");
    }

    public void DisplayPeriod()
    {
        Console.WriteLine($"Start Date: {_startDate} - End Date: {_endDate}.");
        int count = 1;
        foreach (Accomplish accomplish in _accomplish)
        {
            Console.Write($"{count}.  ");
            accomplish.DisplayAccomplish();
            count = count + 1;
        }
    }

}