public class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public string GetSummary()
    {
        string summary = "";
        summary += _date;
        summary += " Running ";
        summary += $"({_length} min)";
        summary += $" - Distance: {CalculateDistance()} km, ";
        summary += $"Speed: {CalculateSpeed()} kph, ";
        summary += $"Pace: {CalculatePace()} min per km";

        return summary;
    }
}