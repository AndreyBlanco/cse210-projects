public class WeeklyPeriod : Periods
{
    private List<string> _sesions = new List<string>();
    
    public WeeklyPeriod(string startDate, string endDate, int sesionTimes) : base(startDate, endDate, sesionTimes)
    {   
        string newDate = "0";
        for (int i = 0; i < sesionTimes; i++)
        {
            _sesions.Add(newDate);
            newDate = newDate + 1;
        }
    }


}