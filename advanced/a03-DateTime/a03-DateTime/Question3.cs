namespace a03_DateTime;

public static class Question3
{
    public static DateTime Execute(DateTime selectedDate)
    {
        var utcTime = TimeZoneInfo.ConvertTimeToUtc(selectedDate, TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time"));
    
        Console.WriteLine($"Original local time (CET): {selectedDate}");
        Console.WriteLine($"Converted to UTC: {utcTime}");
        return utcTime;
    }
}