using System;

abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Encapsulated access
    protected DateTime GetDate() => _date;
    protected int GetMinutes() => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} {this.GetType().Name} ({GetMinutes()} min) - " +
               $"Distance: {GetDistance():0.00} miles, " +
               $"Speed: {GetSpeed():0.00} mph, " +
               $"Pace: {GetPace():0.00} min per mile";
    }
}
