using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random _random = new Random();

    public static HashSet<string> NamesInUse = new HashSet<string>();

    public Robot() => GenerateRobotsName();

    public string Name { get; private set;}

    public void Reset()
    {
        NamesInUse.Remove(Name);
        GenerateRobotsName();
    }

    private void GenerateRobotsName()
    {
        Name = GenerateChar().ToString() + GenerateChar() + GenerateDigit() + GenerateDigit() + GenerateDigit();

        if (NamesInUse.Contains(Name))
        {
            GenerateRobotsName();
        }

        NamesInUse.Add(Name);
    }

    private char GenerateChar() => (char)('A' + _random.Next(0, 26));

    private int GenerateDigit() => _random.Next(0, 9);
}