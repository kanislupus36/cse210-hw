public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            // Add bonus points when target is reached
            // Access _score from GoalManager to update the score
            Console.WriteLine($"Congratulations! {_shortName} checklist completed. You earned an additional {_bonus} points.");
        }
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description} (Completed {_amountCompleted}/{_target} times)";
    }
}