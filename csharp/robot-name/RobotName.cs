using System;
using System.Collections.Generic;

public class Robot
{
    private readonly Random _random;
    private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static HashSet<string> NamesInUse = new HashSet<string>();

    public Robot()
    {
        _random = new Random();
        Name = GenerateRobotsName(); 
    }

    public string Name { get; private set;}

    public void Reset()
    {
        NamesInUse.Remove(Name);
        Name = GenerateRobotsName();
    }

    private string GenerateRobotsName()
    {
        var tempName = (char)('A' + _random.Next() + 'A' + _random.Next()) + _random.Next(0, 9).ToString() + _random.Next(0, 9).ToString() + _random.Next(0, 9).ToString();
        
        if (NamesInUse.Contains(tempName))
        {
            tempName = GenerateRobotsName();
        }

        NamesInUse.Add(tempName);
        return tempName;
    }
}