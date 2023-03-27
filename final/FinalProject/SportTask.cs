public class SportTask : Task
{
    private string _discipline;

    public SportTask(string name, string description, string discipline) : base(name, description)
    {
        _discipline = discipline;
    }

    public SportTask(string name, string description, string notes, string evaluation, Accomplish accomplish, Periods period, string discipline) : base(name, description, notes, evaluation, accomplish, period)
    {
        _discipline = discipline;
    }
}

