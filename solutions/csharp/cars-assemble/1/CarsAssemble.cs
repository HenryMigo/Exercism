static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0,
            >= 1 and <= 4 => 100,
            >= 5 and <= 8 => 90,
            9 => 80,
            10 => 77,
            _ => 0
        };
    }

    public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * 221;

    public static int WorkingItemsPerMinute(int speed) => Convert.ToInt32(Math.Round(ProductionRatePerHour(speed) / 60));
}
