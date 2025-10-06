namespace a03_DateTime;

public static class Question1
{
    public static void Execute()
    {
        
        Bills();
    }

    private static void Bills()
    {
        
        for (var amountBills = 0; amountBills <=3; amountBills++)
        {
            Console.WriteLine($"Bill due Date{amountBills}");
            Console.WriteLine();
            DateTime.TryParse(Console.ReadLine(), out var dueDate);
            
            var today = DateTime.Now;
            var ts = dueDate - today;
                    
            var days = Math.Abs(ts.Days);
            var hours = Math.Abs(ts.Hours);
            var minutes = Math.Abs(ts.Minutes);
            var seconds = Math.Abs(ts.Seconds);
            if (ts < TimeSpan.Zero)
            {
                PrintOverDue(days, hours, minutes, seconds);
            }
            else
            {
                PrintTimeLeft(days, hours, minutes, seconds);
            }
            Console.WriteLine();
        }
        
    }
    private static void PrintOverDue(int days, int hours, int minutes, int seconds)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Your bill is overdue by {days} Days, {hours} Hours, {minutes} Minutes and {seconds} Seconds!");
        Console.ResetColor();
    }
    
    private static void PrintTimeLeft(int days, int hours, int minutes, int seconds)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{days} Days, {hours} Hours, {minutes} Minutes and {seconds} Seconds remain to pay your bill.");
        Console.ResetColor();
    }
}