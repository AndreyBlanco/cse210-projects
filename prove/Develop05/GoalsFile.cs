using System.IO;

public class GoalsFile
{
    private string _name = "";
    private List<Goals> _list = new List<Goals>();

    public GoalsFile()
    {}

    public GoalsFile(string name, List<Goals> goals)
    {
        _name = name;
        _list = goals;
    }

    public void AddSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());        
        SimpleGoal simple = new SimpleGoal(name, description, points);
        _list.Add(simple);
    }

    public void AddEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());        
        EternalGoal eternal = new EternalGoal(name, description, points);
        _list.Add(eternal);
    }

    public void AddCheckListGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());        
        CheckListGoal checkList = new CheckListGoal(name, description, points, times, bonus);
        _list.Add(checkList);
    }

    public void DisplayList()
    {
        Console.Clear();
        Console.WriteLine("The goals are");
        int number = 1;
        foreach (Goals goal in _list)
        {
            Console.Write($"{number}. ");
            goal.DisplayGoal();
            number = number + 1;
        }
    }

    public void Event()
    {
        Console.Clear();
        Console.WriteLine("The goals are");
        int number = 0;
        foreach (Goals goal in _list)
        {
            string name = goal.GetName();
            Console.WriteLine($"{number + 1}. {name}");
            number = number + 1;
        }

        Console.WriteLine();
        if (number !=0)
        {
            Console.Write("Which goal did you accomplish? ");
            int goalidx = int.Parse(Console.ReadLine()) - 1;
            _list[goalidx].RecordEvent();
        }
    }

    public void Edit()
    {
        Console.Clear();
        Console.WriteLine("The goals are");
        int number = 0;
        foreach (Goals goal in _list)
        {
            string name = goal.GetName();
            Console.WriteLine($"{number + 1}. {name}");
            number = number + 1;
        }

        Console.WriteLine();
        if (number !=0)
        {
            Console.Write("Which goal do you want to edit? ");
            int goalidx = int.Parse(Console.ReadLine()) - 1;
            
            string erase = "O";
            while (erase != "Y" && erase != "N")
            {
                Console.Write("Erase Goal (Y/N): ");
                erase = Console.ReadLine().ToUpper();
                if (erase == "Y")
                {
                    _list.RemoveAt(goalidx);
                }
                else if (erase =="N")
                {
                    _list[goalidx].EditGoal();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Plese, try again.");
                    Console.WriteLine();
                }
            }
        }
    }

    public int Score()
    {
        int score = 0;
        foreach (Goals goal in _list)
        {
            score = score + goal.GetScore();
        }
        
        return score;
    }

    public void Save()
    {
        if (_name == "")
        {
            Console.Write("What is the filename for the goal file? ");
            _name = Console.ReadLine();
        }

        using (StreamWriter outPutFile = new StreamWriter(_name))
        {
            foreach (Goals goal in _list)
            {
                outPutFile.WriteLine(goal.GetLine());
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the filename for the goal file? ");
        _name = Console.ReadLine();
    
        string[] lines = System.IO.File.ReadAllLines(_name);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("°");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                _list.Add(simple);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                _list.Add(eternal);
            }
            else if (parts[0] == "CheckListGoal")
            {
                CheckListGoal checkList = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), parts[6]);
                _list.Add(checkList);
            }

        }
    }
}