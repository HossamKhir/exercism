using System;
using System.Collections.Generic;

public static class ScrabbleScore
{
    private static Dictionary<char, int> SCORE = new Dictionary<char, int>(){
        {'a', 1},
        {'e', 1},
        {'i', 1},
        {'o', 1},
        {'u', 1},
        {'l', 1},
        {'n', 1},
        {'r', 1},
        {'s', 1},
        {'t', 1},
        {'d', 2},
        {'g', 2},
        {'b', 3},
        {'c', 3},
        {'m', 3},
        {'p', 3},
        {'f', 4},
        {'h', 4},
        {'v', 4},
        {'w', 4},
        {'y', 4},
        {'k', 5},
        {'j', 8},
        {'x', 8},
        {'q', 10},
        {'z', 10},
    };
    public static int Score(string input)
    {
        // throw new NotImplementedException("You need to implement this function.");
        int result = 0;
        foreach (var letter in input.ToLower())
        {
            result += SCORE[letter];
        }
        return result;
    }
}