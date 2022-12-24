using System;

public class RailFenceCipher
{

    public int Rails { get; set; }

    public RailFenceCipher(int rails)
    {
        Rails = rails;
    }

    public string Encode(string input)
    {
        // throw new NotImplementedException("You need to implement this function.");
        // NOTE: edge case
        if (Rails == 1)
        {
            return input;
        }
        string[] rails = new string[Rails];
        int i = 0;
        int step = 1;
        foreach (var c in input)
        {
            rails[i] += c;
            i += step;
            if (i == Rails)
            {
                i = Rails - 2;
                step *= -1;
            }
            else if (i == -1)
            {
                i = 1;
                step *= -1;
            }
        }
        return String.Concat(rails);
    }

    public string Decode(string input)
    {
        // throw new NotImplementedException("You need to implement this function.");
        // NOTE: edge case
        if (Rails == 1)
        {
            return input;
        }
        char[] result = new char[input.Length];
        int gap = Rails + (Rails - 3);
        int gapComplement = 0;
        int step = 2;
        int i = 0;
        int rail = 0;
        bool goingDown = true;
        foreach (var c in input)
        {
            result[i] = c;
            if ((rail == 0) || (rail == (Rails - 1)))
            {
                i += (gap + 1);
            }
            else
            {
                i += 1 + ((goingDown) ? gap : gapComplement);
                goingDown = !goingDown;
            }
            if (i >= result.Length)
            {
                i = ++rail;
                gap = Math.Max(0, gap - step);
                gapComplement = (gapComplement == 0) ? 1 : (gapComplement + step);
                if (gap == 0)
                {
                    (gap, gapComplement) = (gapComplement, gap);
                }
            }
        }
        return String.Concat(result);
    }
}

/*

W - - - - - I - - - - - R - - - - - E - - - - - E
- E - - - D - S - - - E - E - - - E - A - - - C -
- - A - E - - - C - V - - - D - L - - - T - N - -
- - - R - - - - - O - - - - - F - - - - - O - - -


W - - - - - - - C - - - - - - - L - - - - - - - E
- E - - - - - S - O - - - - - F - E - - - - - C -
- - A - - - I - - - V - - - D - - - E - - - N - -
- - - R - D - - - - - E - E - - - - - A - O - - -
- - - - E - - - - - - - R - - - - - - - T - - - -

*/
