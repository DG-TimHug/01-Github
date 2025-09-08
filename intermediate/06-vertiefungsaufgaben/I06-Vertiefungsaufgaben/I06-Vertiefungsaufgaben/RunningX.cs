namespace I06_Vertiefungsaufgaben;

public static class RunningX
{
    public static void Run()
    {
        Console.Clear();
        var top = 3;
        var left = 20;
        var consoleWidth = Console.WindowWidth;
        
        Updater(left, top);
        try
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                Console.Clear();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W: 
                        top -= 1;
                        break;
                    case ConsoleKey.S:
                        top += 1;
                        break;
                    case ConsoleKey.D:
                        left += 1;
                        break;
                    case ConsoleKey.A:
                        left -= 1;
                        break;
                }
                if (left <= consoleWidth)
                {
                    Console.SetCursorPosition(1,3);
                }
                Updater(left, top);
            }   while (keyInfo.Key != ConsoleKey.X);
        }
        catch (ArgumentException)
        {
            //Console.Write("Sorry. An error has occured (end of map). Please restart the application.");
            //Console.WriteLine();
        }
    }

    private static void Updater(int left, int top)
    {
        Console.SetCursorPosition(left,top);
        Console.Write("X");
    }
}