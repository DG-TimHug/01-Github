namespace I06_Vertiefungsaufgaben;

public class PrintSmileySad
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
            for (var row2 = 0; row2 < smileySad.GetLength(1); row2++)
            {
                Console.Write(smileySad[row1, row2] ? "X, " : " , ");
            }
            Console.WriteLine();
            Console.WriteLine("Hello World!");
            
        }
    }
}