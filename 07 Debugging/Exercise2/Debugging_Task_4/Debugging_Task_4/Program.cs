using System;

namespace Debugging_Task_4
{
    class Program
    {
        //gewünschtes Verhalten:es wird 6 und  9 in die Konsole geschrieben
        private static int NumberOfApples = 1;

        private static void Main(string[] args)
        {
            //You get 5 new apples, add them to the existing apples
            AddNumberOfApples(5);
            Console.WriteLine(NumberOfApples);
            // You get 3 more, add them too
            AddNumberOfApples(3);
            Console.WriteLine(NumberOfApples);
        }

        private static int AddNumberOfApples(int numberOfNewApples)
        {
            return NumberOfApples += numberOfNewApples;
        }
    }
}