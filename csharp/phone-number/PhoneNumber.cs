using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var phoneNumberClean = Regex.Replace(phoneNumber, @"[\D]", string.Empty);

        if (phoneNumberClean.Length == 11 & phoneNumberClean.StartsWith("1"))
        {
            phoneNumberClean = phoneNumberClean[1..];
        }

        return !IsAreaCodeValid(phoneNumberClean) || !IsExchangeCodeValid(phoneNumberClean)
            ? throw new ArgumentException()
            : phoneNumberClean;
    }

    private static bool IsAreaCodeValid(string phoneNumberClean) => phoneNumberClean.Length == 10 && phoneNumberClean[0] != '0' && phoneNumberClean[0] != '1';
    private static bool IsExchangeCodeValid(string phoneNumberClean) => phoneNumberClean.Length == 10 && phoneNumberClean[3] != '0' && phoneNumberClean[3] != '1';
}