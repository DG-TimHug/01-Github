namespace a01_Collections;

public class Question5
{
    public static void Execute()
    {
        Dictionary<string, double> exchangeRatesToChfByCurrency = new Dictionary<string, double>();

        exchangeRatesToChfByCurrency.Add("CHF", 1.0);
        exchangeRatesToChfByCurrency.Add("EUR", 0.94);
        exchangeRatesToChfByCurrency.Add("USD", 0.80);
        var eurToChf = exchangeRatesToChfByCurrency["EUR"];
        var usdToChf = exchangeRatesToChfByCurrency["USD"];
        Console.WriteLine(eurToChf);
        Console.WriteLine(usdToChf);
    }
}