namespace a01_Collections;

public class Question6
{
    public static void ExchangeCourse()
    {
        Dictionary<string, double> exchangeRatesToChfByCurrency = new Dictionary<string, double>();

        exchangeRatesToChfByCurrency.Add("CHF", 1.0);
        exchangeRatesToChfByCurrency.Add("EUR", 0.94);
        exchangeRatesToChfByCurrency.Add("USD", 0.80);
        var chfToChf = exchangeRatesToChfByCurrency["CHF"];
        
        Console.WriteLine("From which Currency do you want to trade from? (ex. EUR, CHF, USD)");
        var userCurrency = Console.ReadLine();

        try
        {
            switch (userCurrency)
            {
                case "EUR":
                {
                    var currentCurrency = "EUR";
                    var eurToChf = exchangeRatesToChfByCurrency["EUR"];
                    ExchangeRateCalculator(eurToChf, chfToChf, currentCurrency);
                    break;
                }

                case "USD":
                {
                    var currentCurrency = "USD";
                    var usdToChf = exchangeRatesToChfByCurrency["USD"];
                    ExchangeRateCalculator(usdToChf, chfToChf, currentCurrency);
                    break;
                }

                case "CHF":
                {
                    var currentCurrency = "CHF";
                    ExchangeRateCalculator(chfToChf, chfToChf, currentCurrency);
                    break;
                }
                default:
                {
                    throw new ArgumentException();
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Currency was not Found!");
        }
    }

    private static void ExchangeRateCalculator(double currency, double swissFranc, string currentCurrency)
    {
        Console.WriteLine("How much would you like to trade?");
        double.TryParse(Console.ReadLine(), out var inputAmount);
        var outInChf = currency * inputAmount;
        var outputAmountInChf = Math.Round(outInChf, 2);
        Console.WriteLine($"That turns into {outputAmountInChf} CHF at an exchange rate of {currency} {currentCurrency} to {swissFranc} CHF.");
    }
}