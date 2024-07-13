public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int Target => _target;
    public int Bonus => _bonus;

    public int AmountCompleted => _amountCompleted;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(GoalManager manager)
{
    _amountCompleted++;
    Console.WriteLine($"Event recorded for {_shortName}. You gained {_points} points.");
    manager.IncreaseScore(int.Parse(_points));

    if (_amountCompleted == _target)
    {
        Console.WriteLine($"Congratulations! {_shortName} checklist completed. You earned an additional {_bonus} points.");
        manager.IncreaseScore(_bonus);
    }
}

    public override string GetDetailsString()
{
    if (_amountCompleted >= _target)
    {
        return $"[X] {_shortName}: {_description} (Completed {_amountCompleted}/{_target} times)";
    }
    else
    {
        return $"[ ] {_shortName}: {_description} (Completed {_amountCompleted}/{_target} times)";
    }
}

}