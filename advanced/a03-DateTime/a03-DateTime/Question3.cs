namespace a03_DateTime;

public static class Question3
{
    public static void Execute()
    {
        var selectedDate = new DateTime(2021, 12, 21, 18, 23, 00, DateTimeKind.Unspecified);
        
        var utcTime = TimeZoneInfo.ConvertTimeToUtc(selectedDate, TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time"));
    
        Console.WriteLine($"Original local time (CET): {selectedDate}");
        Console.WriteLine($"Converted to UTC: {utcTime}");
    }
}