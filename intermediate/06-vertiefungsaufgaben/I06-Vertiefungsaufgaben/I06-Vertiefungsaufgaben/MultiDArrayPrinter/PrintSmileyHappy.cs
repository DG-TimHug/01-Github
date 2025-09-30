namespace I06_Vertiefungsaufgaben.MultiDArrayPrinter;

public static class PrintSmileyHappy
{
    public static void Print()
    {
        var smileyHappy = new bool[,]
        {
            { false, false, false, false, false, false, false, false, false }, 
            { false, true, true, false, false, false, true, true, false }, 
            { false, true, true, false, false, false, true, true, false,},
            { true, false, false, false, true, false, false, false, true,},
            { false, true, false, false, false, false, false, true, false }, 
            { false, false, true, true, true, true, true, false, false },
        };

        for (var row1 = 0; row1 < smileyHappy.GetLength(0); row1++)
        {
            for (var column = 0; column < smileyHappy.GetLength(1); column++)
            {
                Console.Write(smileyHappy[row1, column] ? "X  " : "   ");
            }
            Console.WriteLine();
        }
    }
}