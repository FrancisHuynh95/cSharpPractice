using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = phoneNumber.StartsWith("212");
        string prefix = phoneNumber.Substring(4,3);
        bool isFake = prefix == "555";
        string lastFour = phoneNumber.Substring(8,4);

        (bool, bool, string) res = (isNewYork, isFake, lastFour);
        return res;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        (bool isNewYork, bool isFake, string LocalNumber) res = phoneNumberInfo;

        return res.isFake;

    }
}
