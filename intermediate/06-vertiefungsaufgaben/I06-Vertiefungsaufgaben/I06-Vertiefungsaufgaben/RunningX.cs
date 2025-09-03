namespace I06_Vertiefungsaufgaben;

public static class RunningX
{
    public static void Run()
    {
        Console.Clear();
        var top = 3;
        var left = 20;
        
        Updater(left, top);
        ConsoleKeyInfo keyInfo;
        try
        {
            do
            {

                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                    {
                        Console.Clear();
                        top -= 1;
                        Updater(left, top);
                        break;
                    }

                    case ConsoleKey.S:
                    {
                        Console.Clear();
                        top += 1;
                        Updater(left, top);
                        break;
                    }

                    case ConsoleKey.D:
                    {
                        Console.Clear();
                        left += 1;
                        Updater(left, top);
                        break;
                    }


                    case ConsoleKey.A:
                    {
                        Console.Clear();
                        left -= 1;
                        Updater(left, top);
                        break;
                    }
                }
            } while (keyInfo.Key != ConsoleKey.X);
        }
        catch (Exception)
        {
            Console.Write("Sorry. An error has occured (end of map). Please restart the application.");
            Console.WriteLine();
        }
    }

    private static void Updater(int left, int top)
    {
        Console.SetCursorPosition(left,top);
        Console.Write("X");
    }
}