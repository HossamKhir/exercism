using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    // INFO: LINQ approach
    public static int Sum(IEnumerable<int> multiples, int max) => Enumerable.Range(0, max)
    .Where(elem => multiples.Any(mul => (mul != 0) && (elem % mul == 0)))
    .Sum();
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    //     // INFO: regular approach
    //     // int sum = 0;
    //     // bool[] sieve = new bool[max];
    //     // foreach (var mul in multiples)
    //     // {
    //     //     if (mul == 0)
    //     //     {
    //     //         continue;
    //     //     }
    //     //     if (mul == 1)
    //     //     {
    //     //         sum += ((max-1) * (max)) / 2;
    //     //         continue;
    //     //     }
    //     //     for (int i = 1; (i * mul) < max; ++i)
    //     //     {
    //     //         sum += (sieve[i * mul]) ? 0 : (i * mul);
    //     //         sieve[i * mul] = true;
    //     //     }
    //     // }
    //     // return sum;
    // }
}