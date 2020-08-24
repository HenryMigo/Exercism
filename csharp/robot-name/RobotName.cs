using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random _random = new Random();

    public static HashSet<string> NamesInUse = new HashSet<string>();

    public Robot() => Name = GenerateRobotsName();

    public string Name { get; private set;}

    public void Reset()
    {
        NamesInUse.Remove(Name);
        Name = GenerateRobotsName();
    }

    private string GenerateRobotsName()
    {
        var tempName = GenerateChar().ToString() + GenerateChar() + GenerateDigit() + GenerateDigit() + GenerateDigit();

        do
        {
            GenerateRobotsName();
        } while (NamesInUse.Contains(tempName));

        NamesInUse.Add(tempName);
        return tempName;
    }

    private char GenerateChar() => (char)('A' + _random.Next(0, 26));

    private int GenerateDigit() => _random.Next(0, 9);
}