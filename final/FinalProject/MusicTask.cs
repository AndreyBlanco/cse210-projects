public class MusicTask : Task
{
    private string _instrument;

    public MusicTask(string title, string description, string dateTime, Periods period, string instrument) : base(title, description, dateTime, period)
    {
        _instrument = instrument;
    }

    public MusicTask(string title, string description, string dateTime, string notes, string evaluation, string instrument, Periods period) : base(title, description, dateTime, notes, evaluation, period)
    {
        _instrument = instrument;
    }

        public override void DisplayContent()
    {
        Console.WriteLine($"Task Type: Music, Instrument:{_instrument}.");
        DisplayTask();
    }

    public override void SaveTask(string filename)
    {
        using (StreamWriter w = File.AppendText(filename))
        {
            Periods periodToSave = GetPeriod();
            List<Accomplish> list = periodToSave.GetList();
            w.WriteLine($"T¬Music¬{GetTitle()}¬{GetDescription()}¬{GetDateTime()}¬{GetNotes()}¬{GetEvaluation()}¬{_instrument}¬{periodToSave.GetType()}¬{periodToSave.GetStartDate()}¬{periodToSave.GetEndDate()}");
            foreach (Accomplish item in list)
            {
                w.WriteLine($"A¬{item.GetTheDate()}¬{item.GetStatus()}");
            }
        }
    }
}

