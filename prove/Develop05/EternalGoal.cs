public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals are never completed
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }
}