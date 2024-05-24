public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Abstract method for recording a completed event
    public abstract void RecordEvent();

    // Abstraction method for returning if a goal is complete or not
    public abstract bool IsComplete();

    // Virtual method for listing the details of a goal
    public virtual string GetDetailsString()
    {
        return "";
    }

    // Abstract method for getting a string to save to a file
    public abstract string GetStringRepresentation();
}