using System.Collections.Generic;

public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> proteinLookup = new Dictionary<string, string>
    {
        {"AUG", "Methionine" },
        {"UUU", "Phenylalanine" }, {"UUC", "Phenylalanine" },
        {"UUA", "Leucine" }, {"UUG", "Leucine" },
        {"UCU", "Serine" }, {"UCC", "Serine" }, {"UCA", "Serine" }, {"UCG", "Serine" },
        {"UAU", "Tyrosine" }, {"UAC", "Tyrosine" },
        {"UGU", "Cysteine" }, {"UGC", "Cysteine" },
        {"UGG", "Tryptophan" },
        {"UAA", "STOP" }, {"UAG", "STOP" }, {"UGA", "STOP" }
    };

    public static string[] Proteins(string strand)
    {
        var list = GetListOfProteins(strand);
        var returnedList = GetListOfFullNamedProtetins(list);

        return returnedList.ToArray();
    }

    private static List<string> GetListOfFullNamedProtetins(List<string> list)
    {
        var returnedList = new List<string>();

        foreach (var item in list)
        {
            var convertedItem = proteinLookup.GetValueOrDefault(item);

            if (convertedItem == "STOP")
            {
                break;
            }

            returnedList.Add(convertedItem);
        }

        return returnedList;
    }

    private static List<string> GetListOfProteins(string strand)
    {
        var list = new List<string>();

        for (var i = 0; i <= strand.Length - 3; i += 3)
        {
            list.Add($"{strand[i]}{strand[i + 1]}{strand[i + 2]}");
        }

        return list;
    }
}