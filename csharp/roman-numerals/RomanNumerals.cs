using System;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        // throw new NotImplementedException("You need to implement this function.");
        string res = "";
        int remainder;
        int level = 0;
        string[,] numerals = {
            {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
            {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
            {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
            {"", "M", "MM", "MMM", "MMMM", "", "", "", "", ""},
        };
        while (value > 0)
        {
            remainder = value % 10;
            res = numerals[level, remainder] + res;
            value /= 10;
            level++;
        }
        return res;
    }
}