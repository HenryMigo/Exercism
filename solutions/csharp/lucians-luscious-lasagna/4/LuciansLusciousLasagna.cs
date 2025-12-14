class Lasagna
{
    private const int MinutesInOven = 40;
    
    public int ExpectedMinutesInOven() => MinutesInOven;

    public int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;

    public int PreparationTimeInMinutes(int layersOfLasagna) => layersOfLasagna * 2;

    public int ElapsedTimeInMinutes(int layersOfLasagna, int minutesInOven) => PreparationTimeInMinutes(layersOfLasagna) + minutesInOven;
}
