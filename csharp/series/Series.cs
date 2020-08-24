using System;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        var size = sliceLength > 0 && numbers.Length >= sliceLength ? numbers.Length - sliceLength + 1 : throw new ArgumentException();

        var result = new string[size];

        for (int i = 0; i < size; i++)
        {
            var skipped = numbers.Skip(i).Take(sliceLength).Select(x => x - '0').ToList();
            var combine = "";

            for(var j = 0; j < skipped.Count(); j++)
            {
                combine += skipped[j];
            }

            result[i] = combine;
        }

        return result;
    }
}