public class OneTimePeriod : Periods
{
    public OneTimePeriod(string endDate) : base(endDate, endDate)
    { 
        CreateAccomplish(endDate, endDate);
    }

    public OneTimePeriod(string startDate, string endDate, List<Accomplish> accomplish) : base(startDate, endDate, accomplish)
    {}

    public override void CreateAccomplish(string endDate, string startDate)
    {
        Accomplish accomplish = new Accomplish(endDate);
        SetAccomplish(accomplish);
    }

    public override string GetType()
    {
        return "one";
    }
}