public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What are three things you are grateful for today?",
        "Who are some people you appreciate in your life and why?",
        "What are some small moments that brought you joy recently?",
        "What aspects of your health are you grateful for?",
        "What opportunities are you thankful to have?"
    };

    public GratitudeActivity() : base("Gratitude Activity", "This activity will help you cultivate gratitude by reflecting on things you are thankful for in your life.")
    {

    }

    public void Run()
    {
        Console.WriteLine();
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowSpinner(5);
        JournalGratitude();
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
    }

    private void JournalGratitude()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Thread.Sleep(1000);
        }
    }
}
