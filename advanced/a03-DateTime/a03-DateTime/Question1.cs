namespace a03_DateTime;

public static class Question1
{
    public static void Execute()
    {
        BillSolver(Powerbill);
        Console.WriteLine();
        BillSolver(Phonebill);
        Console.WriteLine();
        BillSolver(CarPayment);
    }

    class Bill
    {
        public required string Debtor;
        public required string BillType;
        public double BillAmount;
        public DateTime BillDueDate;
    }

    private static readonly Bill Powerbill = new()
    {
        Debtor = "John Doe", BillAmount = 423.36, BillDueDate = new DateTime(2025, 10, 31, 12, 00, 00), BillType = "Power Bill"
    };
    private static readonly Bill Phonebill = new()
    {
        Debtor = "Marie Johnson", BillAmount = 99.50, BillDueDate = new DateTime(2025, 10, 06, 12, 00, 00), BillType = "Phone Bill"
    };
    private static readonly Bill CarPayment = new()
    {
        Debtor = "Mike Johnson", BillAmount = 900, BillDueDate = new DateTime(2025, 9, 30, 12, 00, 00), BillType = "Car Payment"
    };

    private static void BillSolver(Bill localBill)
    {
        var today = DateTime.Now;
        var ts = localBill.BillDueDate - today;
                    
        var days = Math.Abs(ts.Days);
        var hours = Math.Abs(ts.Hours);
        var minutes = Math.Abs(ts.Minutes);
        var seconds = Math.Abs(ts.Seconds);
        if (ts < TimeSpan.Zero)
        {
            PrintOverDue(days, hours, minutes, seconds, localBill);
        }
        else
        {
            PrintTimeLeft(days, hours, minutes, seconds, localBill);
        }
        Console.WriteLine();
        
    }
    private static void PrintOverDue(int days, int hours, int minutes, int seconds, Bill localBill)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Dear Ms./Mr. {localBill.Debtor}, your {localBill.BillType} of {localBill.BillAmount} CHF is overdue by {days} Days, {hours} Hours, {minutes} Minutes and {seconds} Seconds! ");
        Console.WriteLine("Please Pay it as soon as possible");
        Console.ResetColor();
    }
    
    private static void PrintTimeLeft(int days, int hours, int minutes, int seconds, Bill localBill)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Dear Ms./Mr. {localBill.Debtor}, {days} Days, {hours} Hours, {minutes} Minutes and {seconds} Seconds remain to pay your {localBill.BillType} of {localBill.BillAmount} CHF.");
        Console.ResetColor();
    }
}