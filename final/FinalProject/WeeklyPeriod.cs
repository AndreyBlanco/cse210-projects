public class WeeklyPeriod : Periods
{
    private int _sesions = 0;
    
    public WeeklyPeriod(string startDate, string endDate) : base(startDate, endDate)
    { 
        CreateAccomplish(startDate, endDate);
    }

    public WeeklyPeriod(string startDate, string endDate, List<Accomplish> tempList) : base(startDate, endDate, tempList)
    { 
       _sesions = tempList.Count;
    }

    public override void CreateAccomplish(string startDate, string endDate)
    {
        DateTime startDateTime = DateTime.Parse(startDate);
        DateTime endDateTime = DateTime.Parse(endDate);

        TimeSpan times = endDateTime - startDateTime;
        int numOfDays = (int) (times.Days / 7);

        DateTime nextDay = startDateTime;

        for (int i = 0; i < numOfDays + 1; i++)
        {
            string currentDay = nextDay.ToString("dd/MM/yyyy");
            Accomplish accomplish = new Accomplish(currentDay);
            SetAccomplish(accomplish); 
            nextDay = nextDay.AddDays(7);
            _sesions = _sesions + 1;
        }
    }

    public override string GetType()
    {
        return "weekly";
    }

    public int GetSesions()
    {
        return _sesions;
    }
}