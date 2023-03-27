public class MusicTask : Task
{
    private string _instrument;

    public MusicTask(string name, string description, string instrument) : base(name, description)
    {
        _instrument = instrument;
    }

    public MusicTask(string name, string description, string notes, string evaluation, Accomplish accomplish, Periods period, string instrument) : base(name, description, notes, evaluation, accomplish, period)
    {
        _instrument = instrument;
    }
}

