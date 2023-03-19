public class CheckListGoal : Goals
{
    private int _times = 0;
    private int _bonus = 0;

    public CheckListGoal(string name, string description, int points, int bonus, int times, string complete) : base (name, description, points, complete)
    {
        _times = times;
        _bonus = bonus;
    }

    public CheckListGoal(string name, string description, int points, int times, int bonus) : base (name, description, points)
    {
        _times = times;
        _bonus = bonus;
    }

    public override int GetScore()
    {
        int complete = int.Parse(GetComplete());
        int points = GetPoints();

        if (complete == _times)
        {
            return _bonus + (points * _times);
        }
        else
        {
            return complete * points;
        }
    }

    public override void RecordEvent()
    {
        int complete = int.Parse(GetComplete());
        int points = GetPoints();        
        
        if (complete < _times)
        {
            complete = complete + 1;
            SetComplete(complete.ToString());

            if (complete == _times)
            {
                Console.WriteLine($"Congratulations! You have earned {points + _bonus} points.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {points} points.");
            }
        }
    }

    public override void EditGoal()
    {
        string type = "0";
        Console.Clear();

        while (type == "0")
        {
            Console.WriteLine("Options:");
            Console.WriteLine("  1. Edit Name");
            Console.WriteLine("  2. Edit Descriptions");
            Console.WriteLine("  3. Edit Points");
            Console.WriteLine("  4. Edit Times");
            Console.WriteLine("  5. Edit Bonus");
            Console.WriteLine("  6. Restart Goal");
            Console.WriteLine("  7. Return Main Menu");
            Console.Write("What do you want to do?:");
            type = Console.ReadLine();
                    
            if (type == "1")
            {
                Console.Write("New Name: ");
                string newName = Console.ReadLine();
                SetName(newName);
                Console.WriteLine("Name edited.");
                type = "0";
            }
            else if (type == "2")
            {
                Console.Write("New Description: ");
                string newDescription = Console.ReadLine();
                SetDescription(newDescription);
                Console.WriteLine("Description edited.");
                type = "0";
            }
            else if (type == "3")
            {
                Console.Write("New Points (Will change the score): ");
                string newPoints = Console.ReadLine();
                SetPoints(int.Parse(newPoints));
                Console.WriteLine("Point edited.");
                type = "0";
            }
            else if (type == "4")
            {
                Console.Write("New Times: ");
                string newTimes = Console.ReadLine();
                _times = int.Parse(newTimes);
                string complete = GetComplete();
                if (int.Parse(complete) > _times)
                {
                    SetComplete(_times.ToString());
                }
                Console.WriteLine("Times edited.");
                type = "0";
            }
            else if (type == "5")
            {
                Console.Write("New Bonus: ");
                string newBonus = Console.ReadLine();
                _bonus = int.Parse(newBonus);
                Console.WriteLine("Bonus edited.");
                type = "0";
            }
            else if (type == "6")
            {
                Console.WriteLine("Goal Restarted");
                SetComplete("0");
                type = "0";
            }
            else if (type == "7")
            {
                Console.Clear();
            }
            else
            {
                type = "0";
                Console.Clear();
                Console.WriteLine("Plese, try again.");
                Console.WriteLine();
            }
        }
    }

    public override void DisplayGoal()
    {
        int complete = int.Parse(GetComplete());
        int points = GetPoints();
        string name = GetName();
        string description = GetDescription();
        
        string checkmark = " ";
        if (complete == _times)
        {
            checkmark = "X";
        }
        Console.WriteLine($"[{checkmark}] {name} ({description}) -- Currently completed: {complete}/{_times}");
    }

    public override string GetLine()
    {
        string complete = GetComplete();
        int points = GetPoints();
        string name = GetName();
        string description = GetDescription();

        return $"CheckListGoal°{name}°{description}°{points}°{_bonus}°{_times}°{complete}";
    }
}