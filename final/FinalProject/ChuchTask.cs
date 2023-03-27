public class ChurchTask : Task
{
    private string _area;

    public ChurchTask(string name, string description, string area) : base(name, description)
    {
        _area = area;
    }

    public SportTask(string name, string description, string notes, string evaluation, Accomplish accomplish, Periods period, string area) : base(name, description, notes, evaluation, accomplish, period)
    {
        _area = area;
    }
}

