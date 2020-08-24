using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _highScores { get; set; }

    public HighScores(List<int> list) => _highScores = list;

    public List<int> Scores() => _highScores;

    public int Latest() => _highScores.LastOrDefault();

    public int PersonalBest() => _highScores.Max();

    public List<int> PersonalTopThree() => _highScores.OrderByDescending(x => x).Take(3).ToList();
}