using System;
using System.Collections.Generic;

namespace Debugging_Task_3
{

    public class Program
    {
        //gewünschtes Verhalten: 'a'    'b'    'c'    'd'    'e'    'f' wird in die Konsole geschrieben
        public static void Main()
        {
            List<Char> characters = new List<Char>();
            characters.InsertRange(0, new Char[] {'a', 'b', 'c', 'd', 'e', 'f'});
            for (int ctr = 0; ctr < characters.Count; ctr++)
                Console.Write("'{0}'    ", characters[ctr]);
        }
    }
}