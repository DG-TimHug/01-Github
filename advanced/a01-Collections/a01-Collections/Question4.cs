namespace a01_Collections;

public class Question4
{
    public static void Execute()
    {
        var amount1 = new Money { Amount = 1.0m, Currency = "CHF" };
        var amount2 = new Money { Amount = 2.0m, Currency = "USD" };
        var amount3 = new Money { Amount = 1.6m, Currency = "EUR" };
        var amount4 = new Money { Amount = 3.2m, Currency = "CHF" };
        var allAmounts = new List<Money>()
        {
            amount1, amount2, amount3, amount4
        };
        var allCurrenciesList = allAmounts.Select(d => d.Currency).ToList();
        var allCurrenciesSet = allCurrenciesList.ToHashSet();
    }

    private class Money
    {
        public decimal Amount { get; set; }

        public string Currency { get; set; }
    }
}
    
