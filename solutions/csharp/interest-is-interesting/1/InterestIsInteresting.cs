static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
            < 0 => 3.213f,
            < 1000 => 0.5f,
            >= 1000 and < 5000 => 1.621f,
            >= 5000 => 2.475f
        };
    }

    public static decimal Interest(decimal balance) => balance * ((decimal)InterestRate(balance) / 100);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var years = 0;
        
        if (balance >= targetBalance)
        {
            return years;
        }

        do
        {
            var newBalance = AnnualBalanceUpdate(balance);
            balance = newBalance;
            years++;
        } while (balance < targetBalance);
        
        return years;
    }
}
