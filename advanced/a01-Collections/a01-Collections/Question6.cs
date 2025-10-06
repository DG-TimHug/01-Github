namespace a01_Collections;

public class Question6
{
    public static void ExchangeCourse()
    {
        Dictionary<string, double> exchangeRatesToChfByCurrency = new Dictionary<string?, double>();

        exchangeRatesToChfByCurrency.Add("CHF", 1.0);
        exchangeRatesToChfByCurrency.Add("EUR", 0.94);
        exchangeRatesToChfByCurrency.Add("USD", 0.80);
        var eurToChf = exchangeRatesToChfByCurrency["EUR"];
        var usdToChf = exchangeRatesToChfByCurrency["USD"];
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
                    Console.WriteLine("How much would you like to trade?");
                    double.TryParse(Console.ReadLine(), out var inputAmount);
                    var outInChf = eurToChf * inputAmount;
                    var outputAmountInChf = Math.Round(outInChf, 2);
                    Console.WriteLine($"That turns into {outputAmountInChf} CHF at an exchange rate of {eurToChf} {currentCurrency} to {chfToChf} CHF.");
                    break;
                }

                case "USD":
                {
                    var currentCurrency = "USD";
                    Console.WriteLine("How much would you like to trade?");
                    double.TryParse(Console.ReadLine(), out var inputAmount);
                    var outInChf = usdToChf * inputAmount;
                    var outputAmountInChf = Math.Round(outInChf, 2);
                    Console.WriteLine($"That turns into {outputAmountInChf} CHF at an exchange rate of {usdToChf} {currentCurrency} to {chfToChf} CHF.");
                    break;
                }

                case "CHF":
                {
                    var currentCurrency = "CHF";
                    Console.WriteLine("How much would you like to trade?");
                    double.TryParse(Console.ReadLine(), out var inputAmount);
                    var outInChf = chfToChf * inputAmount;
                    var outputAmountInChf = Math.Round(outInChf, 2);
                    Console.WriteLine($"That turns into {outputAmountInChf} CHF at an exchange rate of {chfToChf} {currentCurrency} to {chfToChf} CHF.");
                    break;
                }
                default:
                {
                    throw new Exception();
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Currency was not Found!");
        }
    }
}