using System;

public static class Darts
{
    public static int Score(double x, double y) => ((x * x) + (y * y)) switch
    {
        > 100 => 0,
        > 25 => 1,
        > 1 => 5,
        _ => 10
    };
    // {
    //     //    throw new NotImplementedException("You need to implement this function");
    //     double location = (x * x) + (y * y);
    //     if (location <= 1.0)
    //     {
    //         return 10;
    //     }
    //     else if (location <= 25.0)
    //     {
    //         return 5;
    //     }
    //     else if (location <= 100.0)
    //     {
    //         return 1;
    //     }
    //     return 0;
    // }
}
