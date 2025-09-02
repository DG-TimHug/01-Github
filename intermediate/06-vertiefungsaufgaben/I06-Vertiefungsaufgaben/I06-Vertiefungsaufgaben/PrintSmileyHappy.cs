namespace I06_Vertiefungsaufgaben;

public class PrintSmileyHappy
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
            for (var row2 = 0; row2 < smileyHappy.GetLength(1); row2++)
            {
                Console.Write(smileyHappy[row1, row2] ? "X, " : " , ");
            }
            Console.WriteLine();
        }
    }
}