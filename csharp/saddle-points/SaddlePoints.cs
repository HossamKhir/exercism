using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        // throw new NotImplementedException("You need to implement this function.");
        // NOTE: brute force
        int[] maximum = new int[matrix.GetLength(0)];
        int[] minimum = new int[matrix.GetLength(1)];


        int current;

        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            maximum[i] = matrix[i, 0];
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                current = matrix[i, j];
                maximum[i] = (current > maximum[i]) ? current : maximum[i];
            }
        }

        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            minimum[j] = matrix[0, j];
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                current = matrix[i, j];
                minimum[j] = (current < minimum[j]) ? current : minimum[j];
            }
        }

        List<(int, int)> res = new List<(int, int)>();
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                current = matrix[i, j];
                if (current == maximum[i] && current == minimum[j])
                {
                    res.Add((i + 1, j + 1));
                }
            }
        }
        return res.ToArray();
    }
}
