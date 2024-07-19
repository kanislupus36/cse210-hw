public class OutdoorGatheringEvent : Event
{
    private string _weather;
    public OutdoorGatheringEvent(string eventTitle, string description, string date, string time, Address address, string weather) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {_weather}";
    }

    public override string ShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {_eventTitle}\nDate: {_date}";
    }
}