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
            for (var column = 0; column < template.GetLength(1); column++)
            {
                Console.Write(template[row1, column] ? "X  " : "   ");
            }
            Console.WriteLine();
        }
    }
}