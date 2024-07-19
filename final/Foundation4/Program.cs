using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2023, 7, 15), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2023, 7, 16), 45, 20.0));
        activities.Add(new Swimming(new DateTime(2023, 7, 17), 60, 30));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}