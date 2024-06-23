public class Entry 
{
    public string _date { get; set;}
    public string _promptText { get; set;}
    public string _entryText { get; set;}
    public string _gratitude { get; set;}

    public Entry(string date, string promptText, string entryText, string gratitude)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _gratitude = gratitude;
    }


    // displays the entry
    public void Display()
    {
        Console.WriteLine($"[Date: {_date}] - Prompt: {_promptText}: {_entryText}. Something I'm grateful for today: {_gratitude}");
    }
}