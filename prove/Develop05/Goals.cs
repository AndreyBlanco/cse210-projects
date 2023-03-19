public class Goals
{
    private string _name = "";
    private string _description ="";
    private int _points = 0;
    private string _complete = "0";

    public Goals(string name, string description, int points, string complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual int GetScore()
    {
        return 0;
    }

    public virtual void RecordEvent()
    {}

    public virtual void EditGoal()
    {}

    public virtual void DisplayGoal()
    {}

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public string GetComplete()
    {
        return _complete;
    }

    public void SetComplete(string comp)
    {
        _complete = comp;
    }

    public virtual string GetLine()
    {
        return "";
    }
}