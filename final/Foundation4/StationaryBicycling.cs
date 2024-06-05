public class StationaryBicycling : Activity
{
    private double _speed;

    public StationaryBicycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return GetLength() / CalculatePace();
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override string GetEventType()
    {
        return "Stationary Bicycling";
    }
}