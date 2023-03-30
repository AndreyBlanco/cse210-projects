public class Accomplish
{
    private string _result;
    private string _date;

    public Accomplish(string date)
    {
        _date = date;
    }

    public void GetResult(string date)
    {
        _result = "Complete";
    }
}