public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Goal Tracker!");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\n--- List of Goals ---");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"Goal: {goal.GetDetailsString()}");
        }
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple, Eternal, Checklist): ");
        string type = Console.ReadLine().Trim();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine().Trim();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine().Trim();

        Console.Write("Enter points for achieving this goal: ");
        string points = Console.ReadLine().Trim();

        switch (type.ToLower())
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "checklist":
                Console.Write("Enter target amount for this checklist goal: ");
                int target = int.Parse(Console.ReadLine().Trim());
                Console.Write("Enter bonus points for completing the checklist: ");
                int bonus = int.Parse(Console.ReadLine().Trim());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\n--- Record Event ---");
        Console.Write("Enter the name of the goal you completed: ");
        string goalName = Console.ReadLine().Trim();

        Goal goal = _goals.FirstOrDefault(g => g.GetDetailsString() == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            _score += int.Parse(goal._points);
            Console.WriteLine($"Event recorded for {goalName}. You gained {goal._points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name};{goal._shortName};{goal._description};{goal._points}");
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        _goals.Clear();

        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];

                switch (type.ToLower())
                {
                    case "simplegoal":
                        _goals.Add(new SimpleGoal(name, description, points));
                        break;
                    case "eternalgoal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "checklistgoal":
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type '{type}'. Skipping.");
                        break;
                }
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}