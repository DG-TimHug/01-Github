using System.Reflection.Metadata.Ecma335;

namespace I06_Vertiefungsaufgaben;

public static class RunningX
{
    public static void Run()
    {
        var width = 0;
        width = Console.WindowWidth;
        var top = 50;
        var left = 50;
        
        var upArrow = Console.ReadKey().Key == ConsoleKey.UpArrow;
        var downArrow = Console.ReadKey().Key == ConsoleKey.DownArrow;
        if (upArrow != true)
        {
        }
        else
        {
            top -= 1;
        }
        if (downArrow != true)
        {
        }
        else
        {
            top += 1;
        }

        while (true)
        {
            Console.SetCursorPosition(left,top);
            Console.Write("X");
        }
    }
}