using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        // throw new NotImplementedException("You need to implement this function.");
        statement = statement.Trim();
        string upperPattern = @"[A-Z]+";
        string lowerPattern = @"[a-z]+";
        string questionPattern = @".*\?$";
        bool isYell = Regex.IsMatch(statement, upperPattern) && !Regex.IsMatch(statement, lowerPattern);
        bool isQuestion = Regex.IsMatch(statement, questionPattern);
        if (isYell && isQuestion)
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (isYell)
        {
            return "Whoa, chill out!";
        }
        else if (isQuestion)
        {
            return "Sure.";
        }
        else if (String.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }
        else
        {
            return "Whatever.";
        }
    }
}