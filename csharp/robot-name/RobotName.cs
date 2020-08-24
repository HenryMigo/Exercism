using System;
using System.Collections.Generic;

public class Robot
{
    private readonly Random _random;
    private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static List<string> NamesInUse = new List<string>();

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
        var tempLetters = Alphabet[_random.Next(0, 25)].ToString() + Alphabet[_random.Next(0, 25)].ToString();
        var tempNumbers = _random.Next(0, 9).ToString() + _random.Next(0, 9).ToString() + _random.Next(0, 9).ToString();

        var tempName = tempLetters + tempNumbers;

        if (NamesInUse.Contains(tempName))
        {
            tempName = GenerateRobotsName();
        }

        NamesInUse.Add(tempName);
        return tempName;
    }
}