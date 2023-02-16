public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string student, string topic, string title) : base (student, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string title = _title;
        return title;
    }
}