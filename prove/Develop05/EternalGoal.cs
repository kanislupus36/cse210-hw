public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent(GoalManager manager)
{
    Console.WriteLine($"Recorded {_shortName}. You gained {_points} points.");
    manager.IncreaseScore(int.Parse(_points));
}

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }
}