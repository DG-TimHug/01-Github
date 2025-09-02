namespace I06_Vertiefungsaufgaben;

class Program
{
    static void Main(string[] args)
    {
        var multidimensioanlarray = new bool[6, 9]
        {
            { false, false, false, true, true, true, false, false, false }, 
            { false, false, false, true, true, true, false, false, false }, 
            { true, true, true, true, true, true, true, true, true,},
            { true, true, true, true, true, true, true, true, true,},
            { false, false, false, true, true, true, false, false, false }, 
            { false, false, false, true, true, true, false, false, false },
        };
        for (int line = 0; line < 6; line++)
        {
            foreach (var state in multidimensioanlarray)
            {
                for (int placeholder = 0; placeholder <= 6; placeholder++)
                {
                    Console.Write(state ? "X, " : " , ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}