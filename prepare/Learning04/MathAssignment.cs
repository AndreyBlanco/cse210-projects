public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string student, string topic, string book, string problem) : base (student, topic)
    {
        _textbookSection = book;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        string book = _textbookSection;
        string problem = _problems;
        return book + " " + problem;
    }
}