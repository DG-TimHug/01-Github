namespace a03_DateTime;

public static class Question2
{
    public static void Execute()
    {
        var myBirthday = new DateTime(2009, 12, 18);
        var today = DateTime.Now;
        var ts = today - myBirthday;
                    
        var days = ts.Days;
        var hours = ts.Hours;
        var minutes = ts.Minutes;
        var seconds = ts.Seconds;
        Console.Write($"Tim was Born {days} Days, {hours} Hours, {minutes} Minutes and {seconds} Seconds ago!");
    }
}