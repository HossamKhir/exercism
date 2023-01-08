using System;

public static class ResistorColorDuo
{
    // public static string[] colours = new[]{
    //     "black",
    //     "brown",
    //     "red",
    //     "orange",
    //     "yellow",
    //     "green",
    //     "blue",
    //     "violet",
    //     "grey",
    //     "white"
    // };
    public static int Value(string[] colors)
    {
        // throw new NotImplementedException("You need to implement this function.");
        // INFO: brute force approach
        int result = 0;
        for (int pos = 0; pos < 2; ++pos)
        {
            result = (10 * result) + GetColourValue(colors[pos]);
        }
        // for (int pos = 0; pos < 2; ++pos)
        // {
        //     for (int i = 0; i < colours.Length; ++i)
        //     {
        //         if (colors[pos] == colours[i])
        //         {
        //             result = (10 * result) + i;
        //             break;
        //         }
        //     }
        // }
        return result;
    }

    public static int GetColourValue(string colour) => colour switch
    {
        "black" => 0,
        "brown" => 1,
        "red" => 2,
        "orange" => 3,
        "yellow" => 4,
        "green" => 5,
        "blue" => 6,
        "violet" => 7,
        "grey" => 8,
        "white" => 9,
        _ => -1,
    };
}
