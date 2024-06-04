public class StationaryBicycling : Activity
{
    private double _speed;

    public StationaryBicycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return 2;
    }

    public override double CalculateSpeed()
    {
        return 2;
    }

    public override double CalculatePace()
    {
        return 2;
    }
}