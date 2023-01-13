using System;
using System.Collections.Generic;
public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        // throw new NotImplementedException("You need to implement this function.");
        List<string> result = new List<string>();
        int i = 0;
        string operation;
        for (; i < 4; ++i)
        {
            operation = GetOperation(commandValue & (1 << i));
            if (!String.IsNullOrEmpty(operation))
            {
                result.Add(operation);
            }
        }
        if ((commandValue & (1 << i)) == 16)
        {
            result.Reverse();
        }
        return result.ToArray();
    }

    public static string GetOperation(int value) => value switch
    {
        1 => "wink",
        2 => "double blink",
        4 => "close your eyes",
        8 => "jump",
        _ => ""
    };
}
