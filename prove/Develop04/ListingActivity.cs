using System.Diagnostics;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts  = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt inspired recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        Console.WriteLine();
        DisplayStartingMessage();
        int originalDuration = _duration;
        GetRandomPrompt();
        ShowSpinner(5);
        GetListFromUser();
        _duration = originalDuration;
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        
    }

    private List<string> GetListFromUser()
    {
        
        List<string> itemsListed = new List<string>();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("Enter an item (or 'done' to finish): ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
                break;
            itemsListed.Add(item);
            _count++;
        }

        stopwatch.Stop();
        Console.WriteLine($"\nYou listed {_count} items.\n");
        return itemsListed;
    }
}