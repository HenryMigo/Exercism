public class Player
{
    private Random _random;
    
    public Player()
    {
        _random = new Random();
    }
    
    public int RollDie() => _random.Next(1, 19);

    public double GenerateSpellStrength() => _random.NextDouble() * 100;
}
