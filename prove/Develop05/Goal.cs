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

    public virtual void RecordEvent()
    {
        // Implemented in derived classes
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }
}
