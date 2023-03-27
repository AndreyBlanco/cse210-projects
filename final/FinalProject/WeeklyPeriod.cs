public class WeeklyPeriod : Periods
{
    private List<strings> _sesions;
    
    public WeeklyPeriod(string startDate, string endDate, int sesionTimes) : base(startDate, endDate, sesionTimes)
    {   
        
        for (int i = 0; i < sesionTimes; i++)
        {
            _sesions.Add(newDate);
            newDate = newDate + 1;
        }
    }


}