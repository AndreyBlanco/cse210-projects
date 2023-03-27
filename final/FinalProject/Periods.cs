public class Periods
{
    private string _startDate;
    private string _endDate;
    private int _sesionTimes;

    public Periods(string startDate, string endDate, string sesionTimes)
    {
        _startDate = startDate;
        _endDate = endDate;
        _sesionTimes = sesionTimes;
    }

    public Periods(string endDate)
    {
        _startDate = endDate;
        _endDate = endDate;
        _sesionTimes = 1;
    }

    public int GetSesionTimes()
    {
        return _sesionTimes;
    }
}