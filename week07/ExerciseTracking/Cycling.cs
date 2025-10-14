using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    protected double GetSpeedValue() => _speed;

    public override double GetDistance() => (_speed * GetMinutes()) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
