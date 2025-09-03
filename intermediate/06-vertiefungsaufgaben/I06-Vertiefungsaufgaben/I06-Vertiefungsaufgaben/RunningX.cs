namespace I06_Vertiefungsaufgaben;

public static class RunningX
{
    public static void Run()
    {
        var width = 0;
        width = Console.WindowWidth;
        for (var left = 0; left <width ; left++)
        {
            Console.SetCursorPosition(left,15);
            Console.Write("X");
            Task.Delay(5000000);
            Task.Delay(5000000);
            Task.Delay(5000000);
            Task.Delay(5000000);
            Task.Delay(5000000);
            Task.Delay(5000000);
            Console.Clear();
        }
    }
}