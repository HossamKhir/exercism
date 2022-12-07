using System;
using System.Linq;

public static class DifferenceOfSquares
{
    // NOTE: using LINQ approach
    // public static int CalculateSquareOfSum(int max) => Square(Enumerable.Range(1, max).Sum());
    public static int CalculateSquareOfSum(int max)
    {
        // throw new NotImplementedException("You need to implement this function.");
        // NOTE: using math approach
        int sum = max * (max + 1) / 2;
        return sum * sum;
    }

    // NOTE: using LINQ approach
    // public static int CalculateSumOfSquares(int max) => Enumerable.Range(1, max).Sum(Square);
    // NOTE: using math approach
    public static int CalculateSumOfSquares(int max) => (max * (max + 1) * ((max * 2) + 1)) / 6;
    // {
    //     // throw new NotImplementedException("You need to implement this function.");
    //     // var seq = Enumerable.Range(1, max);
    //     // return seq.Aggregate(0, (total, number) => total + (number * number));
    // }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    // {
    //     // throw new NotImplementedException("You need to implement this function.");
    //     int squareSum = CalculateSquareOfSum(max);
    //     int sumSquares = CalculateSumOfSquares(max);
    //     return squareSum - sumSquares;
    // }

    public static int Square(int num) => num * num;
}