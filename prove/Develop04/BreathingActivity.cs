public class BreathingActivity : Activity
{
    private string _breathIn = "";
    private string _breathOut = "";

    public BreathingActivity()
    {
        SetActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        _breathIn = "4";
        _breathOut = "6";
    }

    public BreathingActivity(string activity, string description, string breathIn, string breathOut) : base (activity, description)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        SetTime();
        
        Console.WriteLine("Get ready...");
        RunSpinner();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTime());
        
        while (DateTime.Now < endTime)
        {
            BreathIn(int.Parse(_breathIn));
            BreathOut(int.Parse(_breathOut));
            Console.WriteLine();
        } 

        DisplayEndMessage();
    }

    public void BreathIn(int sec)
    {
        Console.Write("Breathe in...");
        RunCountdown(sec);
    }

    public void BreathOut(int sec)
    {
        Console.Write("Now breathe out...");
        RunCountdown(sec);
    }
}