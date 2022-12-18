using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        // throw new NotImplementedException("You need to implement this function.");
        var result = new List<(int, int, int)>();
        int a, b, c;
        for (a = 1; a < sum; ++a)
        {
            b = ((sum * sum) - (2 * sum * a)) / ((2 * sum) - (2 * a));
            c = sum - b - a;
            if ((a > b) || (a > c) || (b > c))
            {
                break;
            }
            if (c * c == (b * b + a * a))
            {
                result.Add((a, b, c));
            }
        }
        return result.ToArray();
    }
}