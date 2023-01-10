using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        // throw new NotImplementedException();
        int i = 0;
        List<string> result = new List<string>();
        if (subjects.Length == 0)
        {
            return new string[] { };
        }
        while (subjects.Length > (i + 1))
        {
            result.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
            ++i;
        }
        result.Add($"And all for the want of a {subjects[0]}.");
        return result.ToArray();
    }
}