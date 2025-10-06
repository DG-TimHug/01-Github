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
                    Console.WriteLine("How much would you like to trade?");
                    double.TryParse(Console.ReadLine(), out var inputAmount);
                    var outputAmountInChf = eurToChf * inputAmount;
                    Console.WriteLine($"That turns into {outputAmountInChf} CHF!");
                    break;
                }

                case "USD":
                {
                    Console.WriteLine("How much would you like to trade?");
                    double.TryParse(Console.ReadLine(), out var inputAmount);
                    var outputAmountInChf = usdToChf * inputAmount;
                    Console.WriteLine($"That turns into {outputAmountInChf} CHF!");
                    break;
                }

                case "CHF":
                {
                    Console.WriteLine("How much would you like to trade?");
                    double.TryParse(Console.ReadLine(), out var inputAmount);
                    var outputAmountInChf = chfToChf * inputAmount;
                    Console.WriteLine($"That turns into {outputAmountInChf} CHF!");
                    break;
                }

                default:
                {
                    throw new Exception("Currency Not Found!");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Currency was not Found!");
            throw;
        }
    }
}