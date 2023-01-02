using System;
using System.Linq;
public static class ReverseString
{
    // NOTE: LINQ approach (easier readability)
    public static string Reverse(string input) => new(input.Reverse().ToArray());
    // {
    //     // throw new NotImplementedException("You need to implement this function.");
    //     NOTE: Array.Reverse approach (best performance)
    //     char[] arr = input.ToCharArray();
    //     Array.Reverse(arr);
    //     return String.Concat(arr);
    // }
}