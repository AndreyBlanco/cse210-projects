public class SimpleGoal : Goals
{
    public SimpleGoal(string name, string description, int points, string complete) : base (name, description, points, complete)
    {}

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {}

    public override int GetScore()
    {
        string complete = GetComplete();
        int points = GetPoints();
        
        if (complete == "true")
        {
            return points;
        }
        else
        {
            return 0;
        }
    }

    public override void RecordEvent()
    {
        int points = GetPoints();
        
        SetComplete("true");
        Console.WriteLine($"Congratulations! You have earned {points} points.");
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
            Console.WriteLine("  4. Restart Goal");            
            Console.WriteLine("  5. Return Main Menu");
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
                Console.Write("New Points: ");
                string newPoints = Console.ReadLine();
                SetPoints(int.Parse(newPoints));
                Console.WriteLine("Point edited.");
                type = "0";
            }
            else if (type == "4")
            {
                Console.WriteLine("Goal Restarted");
                SetComplete("0");
                type = "0";
            }
            else if (type == "5")
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
        string complete = GetComplete();
        int points = GetPoints();
        string name = GetName();
        string description = GetDescription();

        string checkmark = " ";
        if (complete == "true")
        {
            checkmark = "X";
        }
        Console.WriteLine($"[{checkmark}] {name} ({description})");
    }

    public override string GetLine()
    {
        string complete = GetComplete();
        int points = GetPoints();
        string name = GetName();
        string description = GetDescription();

        return $"SimpleGoal°{name}°{description}°{points}°{complete}";
    }
}