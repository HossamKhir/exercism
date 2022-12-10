using System;

public static class Triangle
{

    public static bool IsValidTriangle(double side1, double side2, double side3) // => ((side1 + side2 + side3 > 0) && ((side1 + side2 >= side3) && (side2 + side3 >= side1) && (side1 + side3 >= side2)));
    {
        bool HasLength = (side1 > 0) && (side2 > 0) && (side3 > 0);
        bool IsTriangle = (side1 + side2 >= side3) && (side2 + side3 >= side1) && (side1 + side3 >= side2);
        return HasLength && IsTriangle;
    }
    public static bool IsScalene(double side1, double side2, double side3) => IsValidTriangle(side1, side2, side3) && ((side1 != side2) && (side2 != side3) && (side1 != side3));
    // {
    //     // throw new NotImplementedException("You need to implement this function.");
    //     // return IsValidTriangle(side1, side2, side3) && (side1 != side2) && (side2 != side3) && (side1 != side3);
    //     return IsValidTriangle(side1, side2, side3) && ((side1 != side2) && (side2 != side3) && (side1 != side3));
    // }

    public static bool IsIsosceles(double side1, double side2, double side3) => IsValidTriangle(side1, side2, side3) && ((side1 == side2) || (side2 == side3) || (side1 == side3));
    // {
    //     // throw new NotImplementedException("You need to implement this function.");
    //     return IsValidTriangle(side1, side2, side3) && ((side1 == side2) || (side2 == side3) || (side1 == side3));
    // }

    public static bool IsEquilateral(double side1, double side2, double side3) => IsValidTriangle(side1, side2, side3) && ((side1 == side2) && (side2 == side3));
    // {
    //     // throw new NotImplementedException("You need to implement this function.");
    //     return IsValidTriangle(side1, side2, side3) && ((side1 == side2) && (side2 == side3));
    // }
}