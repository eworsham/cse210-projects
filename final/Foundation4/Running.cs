public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return 1;
    }

    public override double CalculateSpeed()
    {
        return 1;
    }

    public override double CalculatePace()
    {
        return 1;
    }
}