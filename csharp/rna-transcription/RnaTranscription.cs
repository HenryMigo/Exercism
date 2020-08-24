using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{

    private static readonly IDictionary<char, char> Conversions = new Dictionary<char, char>
    {
        {'G', 'C'},
        {'C', 'G'},
        {'T', 'A'},
        {'A', 'U'},
    };

    public static string ToRna(string nucleotide) => new string(nucleotide.Select(c => Conversions[c]).ToArray());
}