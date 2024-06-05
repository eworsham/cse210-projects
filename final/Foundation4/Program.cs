using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 July 2024", 30, 3);
        StationaryBicycling stationaryBicycling = new StationaryBicycling("04 July 2024", 45, 10);
        LapSwimming lapSwimming = new LapSwimming("05 July 2024", 30, 25);

        List<Activity> activities = [running, stationaryBicycling, lapSwimming];

        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}