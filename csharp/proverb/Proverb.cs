using System;
// using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        // throw new NotImplementedException();
        if (subjects.Length == 0)
        {
            return new string[] { };
        }
        // INFO: LINQ approach
        return subjects.Zip(subjects.Skip(1))
        .Select(pair => $"For want of a {pair.First} the {pair.Second} was lost.")
        .Append($"And all for the want of a {subjects.First()}.")
        .ToArray();
        // INFO: for loop approach
        // string[] result = new string[subjects.Length];
        // for (int i = 0; i < result.Length - 1; ++i)
        // {
        //     result[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
        // }
        // result[^1] = $"And all for the want of a {subjects[0]}.";
        // return result;
        // INFO: brute force approach
        // int i = 0;
        // List<string> result = new List<string>();
        // while (subjects.Length > (i + 1))
        // {
        //     result.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        //     ++i;
        // }
        // result.Add($"And all for the want of a {subjects[0]}.");
        // return result.ToArray();
    }
}