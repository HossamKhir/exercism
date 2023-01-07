using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        // throw new NotImplementedException("You need to implement this function.");
        string[] colours = Colors();
        for (int i = 0; i < colours.Length; ++i)
        {
            if (colours[i] == color)
            {
                return i;
            }
        }
        return colours.Length;
    }

    public static string[] Colors() => new[] {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }
}