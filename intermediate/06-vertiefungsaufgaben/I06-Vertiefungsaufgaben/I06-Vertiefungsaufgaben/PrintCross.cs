namespace I06_Vertiefungsaufgaben;

public class PrintCross
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
            for (var row2 = 0; row2 < cross.GetLength(1); row2++)
            {
                Console.Write(cross[row1, row2] ? "X, " : " , ");
            }
            Console.WriteLine();
        }
    }
}