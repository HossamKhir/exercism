using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        // throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
        string dialing = phoneNumber.Substring(0, 3);
        string prefix = phoneNumber.Substring(4, 3);
        string number = phoneNumber.Substring(8, 4);
        return (dialing == "212", prefix == "555", number);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        // throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
        return phoneNumberInfo.IsFake;
    }
}
