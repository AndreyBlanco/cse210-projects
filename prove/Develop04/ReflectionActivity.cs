public class ReflectionActivity : Activity
{
    private List<string> _promptList = new List<string>();
    private List<string> _questionList = new List<string>();
    private List<int> _questionRemain = new List<int>();

    public ReflectionActivity()
    {
        SetActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");
        
        _questionList.Add("Why was this experience meaningful to you?");
        _questionList.Add("Have you ever done anything like this before?");
        _questionList.Add("How did you get started?");
        _questionList.Add("How did you feel when it was complete?");
        _questionList.Add("What made this time different than other times when you were not as successful?");
        _questionList.Add("What is your favorite thing about this experience?");
        _questionList.Add("What could you learn from this experience that applies to other situations?");
        _questionList.Add("What did you learn about yourself through this experience?");
        _questionList.Add("How can you keep this experience in mind in the future?");

        Remain();
    }

     public ReflectionActivity(string activity, string description) : base (activity, description)
    {
        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you helped someone in need.");
        
        _questionList.Add("Why was this experience meaningful to you?");
        _questionList.Add("Have you ever done anything like this before?");
        _questionList.Add("How did you get started?");
        _questionList.Add("How did you feel when it was complete?");
        _questionList.Add("What made this time different than other times when you were not as successful?");
        _questionList.Add("What is your favorite thing about this experience?");
        _questionList.Add("What could you learn from this experience that applies to other situations?");
        _questionList.Add("What did you learn about yourself through this experience?");
        _questionList.Add("How can you keep this experience in mind in the future?");
    }

    public ReflectionActivity(string activity, string description, List<string> promptList, List<string> questions) : base (activity, description)
    {
        _promptList = promptList;
        _questionList = questions;
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        SetTime();
        
        Console.WriteLine("Get ready...");
        RunSpinner();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine("--- " + RunPrompt() + " ---");
        Console.WriteLine();
        Console.WriteLine("When you have someting in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        RunCountdown(4);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTime());
        
        while (DateTime.Now < endTime)
        {
            ShowQuestions();            
        } 
        
        Console.WriteLine();

        DisplayEndMessage();
    }

    private void ShowQuestions()
    {
        Random rnd = new Random();
        if (_questionRemain.Count == 0)
        {
            Remain();
        }
        int selection = rnd.Next(_questionRemain.Count);
        Console.Write("> " + _questionList[_questionRemain[selection]] + " ");
        _questionRemain.RemoveAt(selection);
        RunSpinner();
    }

    private string RunPrompt()
    {
        Random rnd = new Random();
        return  _promptList[rnd.Next(4)];
    }

    private void Remain()
    {
        for (int  i = 0; i < _questionList.Count; i++)
        {
            _questionRemain.Add(i);
        }
    }
}