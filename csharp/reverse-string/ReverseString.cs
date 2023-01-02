using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        // throw new NotImplementedException("You need to implement this function.");
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return String.Concat(arr);
    }
}