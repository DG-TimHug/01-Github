using System;

namespace Debugging_Task_4
{
    class Program
    {
        //gewünschtes Verhalten:es wird 6 und  9 in die Konsole geschrieben
        private const int numberOfApples = 1;
        static void Main(string[] args)
        {
            //You get 5 new apples, add them to the existing apples
            AddNumberOfApples(5);
            Console.WriteLine(numberOfApples);
            // You get 3 more, add them too
            AddNumberOfApples(3);
            Console.WriteLine(numberOfApples);
        }

        static int AddNumberOfApples(int numberOfNewApples)
        {
            return numberOfApples + numberOfNewApples;
        }
    }
}