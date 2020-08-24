using System;

public class SpaceAge
{
    private readonly double _seconds;
    private readonly double earthYears;
    private readonly double oneYear = 31557600;

    public SpaceAge(long seconds)
    {
        _seconds = seconds;
        earthYears = _seconds / oneYear;
    }

    public double OnEarth() => Math.Round(earthYears, 2);

    public double OnMercury() => workOutYears(0.2408467);

    public double OnVenus() => workOutYears(0.61519726);

    public double OnMars() => workOutYears(1.8808158);

    public double OnJupiter() => workOutYears(11.862615);

    public double OnSaturn() => workOutYears(29.447498);

    public double OnUranus() => workOutYears(84.016846);

    public double OnNeptune() => workOutYears(164.79132);

    private double workOutYears(double planetYears)
    {
        var stringValue = earthYears / planetYears;

        return double.Parse(stringValue.ToString("#.##"));
    }
}