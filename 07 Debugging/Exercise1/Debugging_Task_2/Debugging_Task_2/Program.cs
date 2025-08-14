using System;

namespace Debugging_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gewünschtes Verhalten: 2000000000 und 1000000000 addiert und 3000000000 wird in die Konsole geschrieben
            int x = 2000000000;               
            int y = 1000000000;               
            int z = x + y;                
            Console.WriteLine(z);                
        }
    }
}