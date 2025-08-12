using System.ComponentModel.Design;
using System.Diagnostics;

namespace _04_Verzweigungen2;

class Program2
{
    static void Main1(string[] args)
    {   
        Console.WriteLine("Choose a Color: 1 = Red, 2 = Blue, 3 = Green, 4 = Yellow");
        var input = Console.ReadLine();
        int.TryParse(input, out var output);
        var red = 1;
        var blue = 2;
        var green = 3;
        var yellow = 4;
        for (var num = 1; num <= 4; num++)
        {
            if (output != 4)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine("saf");
            }
        }
       
    }
}
