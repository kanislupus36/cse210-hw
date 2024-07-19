public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string ShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {_eventTitle}\nDate: {_date}";
    }
}