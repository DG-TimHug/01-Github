namespace I06_Vertiefungsaufgaben.MultiDArrayPrinter;

public static class Template
{
    public static void PrintTemplate6X9()
    {
        var template = new bool[,]
        {
            { false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false,},
            { false, false, false, false, false, false, false, false, false,},
            { false, false, false, false, false, false, false, false, false }, 
            { false, false, false, false, false, false, false, false, false },
        };

        for (var row1 = 0; row1 < template.GetLength(0); row1++)
        {
            for (var row2 = 0; row2 < template.GetLength(1); row2++)
            {
                Console.Write(template[row1, row2] ? "X  " : "   ");
            }
            Console.WriteLine();
        }
    }
}