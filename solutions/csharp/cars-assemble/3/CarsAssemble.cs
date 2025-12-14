static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0,
            >= 1 and <= 4 => 1,
            >= 5 and <= 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0
        };
    }

    public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * (speed * 221);

    public static int WorkingItemsPerMinute(int speed) => Convert.ToInt32(Math.Floor(ProductionRatePerHour(speed) / 60));
}
