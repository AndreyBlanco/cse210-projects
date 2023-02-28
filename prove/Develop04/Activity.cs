public class Activity
{
    private string _activity = "";
    private string _description = "";
    private string _time = "";
    private string _startMessage = "";
    private string _endMessage = "";

    public Activity()
    {

    }

    public Activity(string activity, string description, string time, string start, string end)
    {
        _activity = activity;
        _description = description;
        _time = time;
        _startMessage = start;
        _endMessage = end;
    }

    public void RunActivity()
    {
        ;
    }

    public void RunSpinner()
    {
        ;
    }

    public void RunCountdown()
    {
        ;
    }

    public void DisplayStartMessage()
    {
        ;
    }

    public void DisplayEndMessage()
    {
        ;
    }

    public void GetTime()
    {
        ;
    }
}