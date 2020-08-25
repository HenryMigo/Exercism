using System.Collections.Generic;

public static class Proverb
{
    private const string Piece1 = "For want of a {0} the {1} was lost.";
    private const string Piece2 = "And all for the want of a {0}.";


    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0)
        {
            return new string[] { };
        }

        var returnList = new List<string>();

        if (subjects.Length > 1)
        {
            for (var i = 0; i < subjects.Length - 1; i++)
            {
                returnList.Add(string.Format(Piece1, subjects[i], subjects[i + 1]));
            }
        }

        returnList.Add(string.Format(Piece2, subjects[0]));

        return returnList.ToArray();
    }
}