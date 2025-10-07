namespace a01_Collections;

public static class Question5
{
    public static void Execute()
    {
        var exchangeRatesToChfByCurrency = new Dictionary<string, double>
        {
            { "CHF", 1.0 },
            { "EUR", 0.94 },
            { "USD", 0.80 }
        };

        var eurToChf = exchangeRatesToChfByCurrency["EUR"];
        var usdToChf = exchangeRatesToChfByCurrency["USD"];
        Console.WriteLine(eurToChf);
        Console.WriteLine(usdToChf);
    }
}