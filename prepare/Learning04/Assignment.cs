public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }

    public string GetSummary()
    {
        string student = _studentName;
        string topic = _topic;
        return student + " - " + topic;
    }
}