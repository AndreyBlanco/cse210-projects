public class HomeTask : Task
{
    private string _dependence;

    public HomeTask(string title, string description, string dateTime, Periods period, string dependence) : base(title, description, dateTime, period)
    {
        _dependence = dependence;
    }

    public HomeTask(string title, string description, string dateTime, string notes, string evaluation, string dependence, Periods period) : base(title, description, dateTime, notes, evaluation, period)
    {
        _dependence = dependence;
    }

    public override void DisplayContent()
    {
        Console.WriteLine($"Task Type: Home, Dependence Task:{_dependence}.");
        DisplayTask();
    }

    public override void SaveTask(string filename)
    {
        using (StreamWriter w = File.AppendText(filename))
        {
            Periods periodToSave = GetPeriod();
            List<Accomplish> list = periodToSave.GetList();
            w.WriteLine($"T¬Home¬{GetTitle()}¬{GetDescription()}¬{GetDateTime()}¬{GetNotes()}¬{GetEvaluation()}¬{_dependence}¬{periodToSave.GetType()}¬{periodToSave.GetStartDate()}¬{periodToSave.GetEndDate()}");
            foreach (Accomplish item in list)
            {
                w.WriteLine($"A¬{item.GetTheDate()}¬{item.GetStatus()}");
            }
        }
    }
}

