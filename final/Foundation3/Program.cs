using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address("123 Main St", "Salt Lake", "UT", "84000");

        LectureEvent lectureEvent = new LectureEvent("Tech Talk", "Learn about new technologies", "Friday", "7:30", eventAddress, "John Doe", 50);
        ReceptionEvent receptionEvent = new ReceptionEvent("Networking Reception", "Connect with industry professionals", "Next Saturday", "8:00", eventAddress, "rsvp@example.com");
        OutdoorGatheringEvent outdoorEvent = new OutdoorGatheringEvent("Community BBQ", "Enjoy a day outdoors with great food", "Next Next Tuesday", "6:00", eventAddress, "Sunny with a chance of clouds");

        Console.WriteLine("Standard Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine("-------------");
        Console.WriteLine(lectureEvent.FullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine("------------------");
        Console.WriteLine(lectureEvent.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine("-------------");
        Console.WriteLine(receptionEvent.FullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine("------------------");
        Console.WriteLine(receptionEvent.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine("-------------");
        Console.WriteLine(outdoorEvent.FullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine("------------------");
        Console.WriteLine(outdoorEvent.ShortDescription());
        Console.WriteLine();
    }
}