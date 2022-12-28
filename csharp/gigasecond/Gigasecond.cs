using System;

public static class Gigasecond
{
    public const double GIGASECOND = 1e9;
    public static DateTime Add(DateTime moment) => moment.AddSeconds(GIGASECOND);
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }
}