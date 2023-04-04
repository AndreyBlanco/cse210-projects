public class ChurchTask : Task
{
    private string _area;

    public ChurchTask(string title, string description, string dateTime, Periods period, string area) : base(title, description, dateTime, period)
    {
        _area = area;
    }

    public ChurchTask(string title, string description, string dateTime, string notes, string evaluation, string area, Periods period) : base(title, description, dateTime, notes, evaluation, period)
    {
        _area = area;
    }

    public override void DisplayContent()
    {
        Console.WriteLine($"Task Type: Church, Area:{_area}.");
        DisplayTask();
    }

    public override void SaveTask(string filename)
    {
        using (StreamWriter w = File.AppendText(filename))
        {
            Periods periodToSave = GetPeriod();
            List<Accomplish> list = periodToSave.GetList();
            w.WriteLine($"T¬Church¬{GetTitle()}¬{GetDescription()}¬{GetDateTime()}¬{GetNotes()}¬{GetEvaluation()}¬{_area}¬{periodToSave.GetType()}¬{periodToSave.GetStartDate()}¬{periodToSave.GetEndDate()}");
            foreach (Accomplish item in list)
            {
                w.WriteLine($"A¬{item.GetTheDate()}¬{item.GetStatus()}");
            }
        }
    }

}

