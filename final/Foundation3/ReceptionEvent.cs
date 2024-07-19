public class ReceptionEvent : Event
{
    private string _rsvp;

    public ReceptionEvent(string eventTitle, string description, string date, string time, Address address, string rsvp) : base(eventTitle, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nType: Reception\nRSVP Email: {_rsvp}";
    }

    public override string ShortDescription()
    {
        return $"Event Type: Reception\nTitle: {_eventTitle}\nDate: {_date}";
    }
}