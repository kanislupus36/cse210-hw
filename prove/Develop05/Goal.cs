public class Goal
{
    public string _shortName;
    public string _description;
    public string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent(GoalManager manager)
{
    // Basic implementation; should be overridden in derived classes
    Console.WriteLine($"Event recorded for {_shortName}. You gained {_points} points.");
}


    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }
}
