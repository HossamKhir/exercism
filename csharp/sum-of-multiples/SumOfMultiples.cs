using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        // throw new NotImplementedException("You need to implement this function.");
        // INFO: regular approach
        int sum = 0;
        bool[] sieve = new bool[max];
        foreach (var mul in multiples)
        {
            if (mul == 0)
            {
                continue;
            }
            if (mul == 1)
            {
                sum += ((max-1) * (max)) / 2;
                continue;
            }
            for (int i = 1; (i * mul) < max; ++i)
            {
                sum += (sieve[i * mul]) ? 0 : (i * mul);
                sieve[i * mul] = true;
            }
        }
        return sum;
    }
}