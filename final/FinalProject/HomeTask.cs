public class HomeTask : Task
{
    private string _dependence;

    public HomeTask(string name, string description, string dependence) : base(name, description)
    {
        _dependence = dependence;
    }

    public HomeTask(string name, string description, string notes, string evaluation, Accomplish accomplish, Periods period, string dependence) : base(name, description, notes, evaluation, accomplish, period)
    {
        _dependence = dependence;
    }
}

