public class EternalGoal : Goals
{
    public EternalGoal(string name, string description, int points, string complete) : base (name, description, points, complete)
    {}

    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {}

    public override int GetScore()
    {
        int complete = int.Parse(GetComplete());
        int points = GetPoints();

        return complete * points;
    }

    public override void RecordEvent()
    {
        int complete = int.Parse(GetComplete());
        int points = GetPoints();
        
        complete = complete + 1;
        SetComplete(complete.ToString());

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
        string name = GetName();
        string description = GetDescription();
        
        Console.WriteLine($"[ ] {name} ({description})");
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