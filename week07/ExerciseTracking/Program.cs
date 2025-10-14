using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>()
        {
            new Running(new DateTime(2025, 11, 10), 30, 3.0),
            new Cycling(new DateTime(2025, 11, 11), 45, 12.0),
            new Swimming(new DateTime(2025, 11, 12), 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}