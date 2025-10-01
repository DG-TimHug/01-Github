namespace a01_Collections;

public class Question5
{
    public static void Execute()
    {
        Dictionary<string,double > ExchangeRatesToChfByCurrency = new Dictionary<string, double>();
        
        ExchangeRatesToChfByCurrency.Add("CHF", 1.0);
        ExchangeRatesToChfByCurrency.Add("EUR", 0.94);
        ExchangeRatesToChfByCurrency.Add("USD", 0.80);
        var eurToChf = ExchangeRatesToChfByCurrency["EUR"];
        var usdToChf = ExchangeRatesToChfByCurrency["USD"];
        Console.WriteLine(eurToChf);
        Console.WriteLine(usdToChf);
    }
}