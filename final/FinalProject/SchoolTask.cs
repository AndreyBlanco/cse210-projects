public class SchoolTask : Task
{
    private string _subject;

    public SchoolTask(string title, string description, string dateTime, Periods period, string subject) : base(title, description, dateTime, period)
    {
        _subject = subject;
    }

    public SchoolTask(string title, string description, string dateTime, string notes, string evaluation, string subject, Periods period) : base(title, description, dateTime, notes, evaluation, period)
    {
        _subject = subject;
    }

    public override void DisplayContent()
    {
        Console.WriteLine($"Task Type: School, Subject:{_subject}.");
        DisplayTask();
    }

    public override void SaveTask(string filename)
    {
        using (StreamWriter w = File.AppendText(filename))
        {
            Periods periodToSave = GetPeriod();
            List<Accomplish> list = periodToSave.GetList();
            w.WriteLine($"T¬School¬{GetTitle()}¬{GetDescription()}¬{GetDateTime()}¬{GetNotes()}¬{GetEvaluation()}¬{_subject}¬{periodToSave.GetType()}¬{periodToSave.GetStartDate()}¬{periodToSave.GetEndDate()}");
            foreach (Accomplish item in list)
            {
                w.WriteLine($"A¬{item.GetTheDate()}¬{item.GetStatus()}");
            }
        }
    }
}

