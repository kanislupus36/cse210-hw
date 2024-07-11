public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Simple goals are completed immediately
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }
}
