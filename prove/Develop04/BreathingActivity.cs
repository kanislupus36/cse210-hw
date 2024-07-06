public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        Console.WriteLine();
        DisplayStartingMessage();
        int originalDuration = _duration;
        while (_duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            _duration -= 3;

            if (_duration <= 0)
                break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            _duration -= 3;

            if (_duration <= 0)
                break;
        }
        _duration = originalDuration;
        DisplayEndingMessage();
    }
}