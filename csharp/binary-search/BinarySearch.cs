using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        // throw new NotImplementedException("You need to implement this function.");
        int result = Array.BinarySearch(input, value);
        return (result >= 0) ? result : -1;
    }
}