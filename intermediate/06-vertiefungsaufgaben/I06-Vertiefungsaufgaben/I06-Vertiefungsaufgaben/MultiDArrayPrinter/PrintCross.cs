namespace I06_Vertiefungsaufgaben.MultiDArrayPrinter;

public static class PrintCross
{
    public static void Print() {
        var cross = new bool[,]
        {
            { false, false, false, true, true, true, false, false, false }, 
            { false, false, false, true, true, true, false, false, false }, 
            { false, true, true, true, true, true, true, true, false,},
            { false, true, true, true, true, true, true, true, false,},
            { false, false, false, true, true, true, false, false, false }, 
            { false, false, false, true, true, true, false, false, false },
        };

        for (var row1 = 0; row1 < cross.GetLength(0); row1++)
        {
            for (var column = 0; column < cross.GetLength(1); column++)
            {
                Console.Write(cross[row1, column] ? "X  " : "   ");
            }
            Console.WriteLine();
        }
    }
}