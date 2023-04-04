public class SportTask : Task
{
    private string _discipline;

    public SportTask(string title, string description, string dateTime, Periods period, string discipline) : base(title, description, dateTime, period)
    {
        _discipline = discipline;
    }

    public SportTask(string title, string description, string dateTime, string notes, string evaluation, string discipline, Periods period) : base(title, description, dateTime, notes, evaluation, period)
    {
        _discipline = discipline;
    }

    public override void DisplayContent()
    {
        Console.WriteLine($"Task Type: Sport, Discipline:{_discipline}.");
        DisplayTask();
    }

    public override void SaveTask(string filename)
    {
        using (StreamWriter w = File.AppendText(filename))
        {
            Periods periodToSave = GetPeriod();
            List<Accomplish> list = periodToSave.GetList();
            w.WriteLine($"T¬Sport¬{GetTitle()}¬{GetDescription()}¬{GetDateTime()}¬{GetNotes()}¬{GetEvaluation()}¬{_discipline}¬{periodToSave.GetType()}¬{periodToSave.GetStartDate()}¬{periodToSave.GetEndDate()}");
            foreach (Accomplish item in list)
            {
                w.WriteLine($"A¬{item.GetTheDate()}¬{item.GetStatus()}");
            }
        }
    }
}

