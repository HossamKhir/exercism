using System;

public class SpaceAge
{
    public double Age { get; set; }
    public const long SECONDS_IN_YEAR = 31557600;
    public SpaceAge(int seconds)
    {
        Age = (double)seconds / (double)SECONDS_IN_YEAR;
    }

    public double OnEarth() => Age;
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }

    public double OnMercury() => Age / 0.2408467;
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }

    public double OnVenus() => Age / 0.61519726;
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }

    public double OnMars() => Age / 1.8808158;
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }

    public double OnJupiter() => Age / 11.862615;
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }

    public double OnSaturn() => Age / 29.447498;
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }

    public double OnUranus() => Age / 84.016846;
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }

    public double OnNeptune() => Age / 164.79132;
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }
}