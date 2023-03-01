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

    public Activity(string activity, string description)
    {
        _activity = activity;
        _description = description;
        _startMessage = "Welcome to the " + activity + ".";
        _endMessage = "";
    }

    public void SetActivity(string activity, string description)
    {
        _activity = activity;
        _description = description;
        _startMessage = "Welcome to the " + activity + ".";
        _endMessage = "";
    }

    public void RunSpinner()
    {
        List<string> spinner = new List<string>();

        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("─");
        spinner.Add("\\");
        
        for (int i = 2; i > 0; i--)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }

    public void RunCountdown(int sec)
    {
        for (int i = sec; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine(_startMessage);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void SetTime()
    {
        Console.Write("How long, in seconds, would you like for your sesion? ");
        _time = Console.ReadLine();
        _endMessage = "You have completed another " + _time + " seconds of the " + _activity + ".";
        Console.Clear();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        RunSpinner();
        Console.WriteLine(_endMessage);
        RunSpinner();
        Console.Clear();
    }

    public int GetTime()
    {
        return int.Parse(_time);
    }
}
