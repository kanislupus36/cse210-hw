public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _completed = false;
    }

    public override void RecordEvent(GoalManager manager)
{
    Console.WriteLine($"Goal '{_shortName}' completed! You gained {_points} points.");
    manager.IncreaseScore(int.Parse(_points));
    _completed = true;
}

    public override string GetDetailsString()
    {
        string status = _completed ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description}";
    }
}
