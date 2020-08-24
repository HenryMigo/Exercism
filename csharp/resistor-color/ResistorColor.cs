using System;
using System.Linq;

public static class ResistorColor
{
    public static int ColorCode(string color) => (int)Enum.Parse(typeof(Colours), color);

    public static string[] Colors() => Enum.GetNames(typeof(Colours)).ToArray();

    private enum Colours
    {
        black = 0,
        brown = 1,
        red = 2,
        orange = 3,
        yellow = 4,
        green = 5,
        blue = 6,
        violet = 7,
        grey = 8,
        white = 9
    }
}