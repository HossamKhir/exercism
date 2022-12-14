using System;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delim)
    {
        int index = str.IndexOf(delim) + delim.Length;
        return str.Substring(index);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string delim1, string delim2)
    {
        int start = str.IndexOf(delim1) + delim1.Length;
        int end = str.LastIndexOf(delim2);
        return str.Substring(start, end - start);
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}