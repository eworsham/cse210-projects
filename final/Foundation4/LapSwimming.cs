public class LapSwimming : Activity
{
    private double _numberOfLaps;

    public LapSwimming(string date, double length, double numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double CalculateDistance()
    {
        return 3;
    }

    public override double CalculateSpeed()
    {
        return 3;
    }

    public override double CalculatePace()
    {
        return 3;
    }
}