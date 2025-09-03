namespace I06_Vertiefungsaufgaben;

public static class RunningX
{
    public static void Run()
    {
        var width = 0;
        width = Console.WindowWidth;
        var top = 6;
        for (var left = 0; left < width; left++)
        {
            Console.SetCursorPosition(left,top);
           Console.Write("X");
           Thread.Sleep(150);
            Console.Clear();
        }
    }
}