namespace I06_Vertiefungsaufgaben.MultiDArrayPrinter;

public static class PrintSmileySad
{
    public static void Print()
    {
        var smileySad = new bool[,]
        {
            { false, true, true, false, false, false, true, true, false }, 
            { false, true, true, false, true, false, true, true, false }, 
            { false, false, false, false, false, false, false, false, false,},
            { false, false, true, true, true, true, true, false, false,},
            { false, true, false, false, false, false, false, true, false }, 
            { true, false, false, false, false, false, false, false, true },
        };

        for (var row1 = 0; row1 < smileySad.GetLength(0); row1++)
        {
            for (var column = 0; column < smileySad.GetLength(1); column++)
            {
                Console.Write(smileySad[row1, column] ? "X  " : "   ");
            }
            Console.WriteLine();
        }
    }
}