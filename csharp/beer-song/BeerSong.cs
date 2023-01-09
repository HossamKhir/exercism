using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        // throw new NotImplementedException("You need to implement this function.");
        string res = "";
        string bottles = "bottle" + ((startBottles == 1) ? "" : "s");
        while (takeDown > 0)
        {
            switch (startBottles)
            {
                case 1:
                    res += $"{startBottles} {bottles} of beer on the wall, {startBottles} {bottles} of beer.\n" +
                    "Take it down and pass it around, no more bottles of beer on the wall.";
                    --startBottles;
                    break;
                case 0:
                    startBottles = 99;
                    res += "No more bottles of beer on the wall, no more bottles of beer.\n" +
                    "Go to the store and buy some more, 99 bottles of beer on the wall.";
                    break;
                default:
                    res += $"{startBottles} {bottles} of beer on the wall, {startBottles} {bottles} of beer.\n";
                    --startBottles;
                    bottles = "bottle" + ((startBottles == 1) ? "" : "s");
                    res += $"Take one down and pass it around, {startBottles} {bottles} of beer on the wall.";
                    break;
            }
            --takeDown;
            if (takeDown > 0)
            {
                res += "\n\n";
            }
        }
        return res;
    }
}