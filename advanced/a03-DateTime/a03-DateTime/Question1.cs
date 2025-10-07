using System.Runtime.InteropServices.JavaScript;

namespace a03_DateTime;

public static class Question1
{
    public static void Execute()
    {
        BillSolver(Powerbill.billDueDate, Powerbill.debtor, Powerbill.billAmount, Powerbill.billType);
        Console.WriteLine();
        BillSolver(Phonebill.billDueDate, Phonebill.debtor, Phonebill.billAmount, Phonebill.billType);
        Console.WriteLine();
        BillSolver(CarPayment.billDueDate, CarPayment.debtor, CarPayment.billAmount, CarPayment.billType);
    }

    class Bill
    {
        public string debtor;
        public string billType;
        public double billAmount;
        public DateTime billDueDate;
    }

    private static Bill Powerbill = new()
    {
        debtor = "John Doe", billAmount = 423.36, billDueDate = new DateTime(2025, 10, 31, 12, 00, 00), billType = "Power Bill"
    };
    private static Bill Phonebill = new()
    {
        debtor = "Marie Johnson", billAmount = 99.50, billDueDate = new DateTime(2025, 10, 06, 12, 00, 00), billType = "Phone Bill"
    };
    private static Bill CarPayment = new()
    {
        debtor = "Mike Johnson", billAmount = 900, billDueDate = new DateTime(2025, 9, 30, 12, 00, 00), billType = "Car Payment"
    };

    private static void BillSolver(DateTime dueDate, string debtor, double amount, string billType)
    {
        var today = DateTime.Now;
        var ts = dueDate - today;
                    
        var days = Math.Abs(ts.Days);
        var hours = Math.Abs(ts.Hours);
        var minutes = Math.Abs(ts.Minutes);
        var seconds = Math.Abs(ts.Seconds);
        if (ts < TimeSpan.Zero)
        {
            PrintOverDue(days, hours, minutes, seconds, debtor, amount, billType);
        }
        else
        {
            PrintTimeLeft(days, hours, minutes, seconds, debtor, amount, billType );
        }
        Console.WriteLine();
        
        
    }
    private static void PrintOverDue(int days, int hours, int minutes, int seconds, string debtor, double billAmount, string billType)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Dear Ms./Mr. {debtor}, your {billType} of {billAmount} CHF is overdue by {days} Days, {hours} Hours, {minutes} Minutes and {seconds} Seconds! ");
        Console.WriteLine("Please Pay it as soon as possible");
        Console.ResetColor();
    }
    
    private static void PrintTimeLeft(int days, int hours, int minutes, int seconds, string debtor, double billAmount, string billType)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Dear Ms./Mr. {debtor}, {days} Days, {hours} Hours, {minutes} Minutes and {seconds} Seconds remain to pay your {billType} of {billAmount} CHF.");
        Console.ResetColor();
    }
}