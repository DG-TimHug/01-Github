using System;

namespace Debugging_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gewünschtes Verhalten: 2000000000 und 1000000000 addiert und 3000000000 wird in die Konsole geschrieben
            long x = 2000000000;               
            long y = 1000000000;               
            long z = x + y;                
            Console.WriteLine(z);        
            
            
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(unchecked(int.MaxValue + 1)); //example of maximum Int
            Console.WriteLine(int.MinValue);
        }
    }
}