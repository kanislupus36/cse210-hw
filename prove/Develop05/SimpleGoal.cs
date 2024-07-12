public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
         Console.WriteLine($"Goal '{_shortName}' completed! You gained {_points} points.");
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }
}
