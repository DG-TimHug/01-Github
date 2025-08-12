using System.ComponentModel.Design;

namespace _04_Verzweigungen;

class Program
{
    static void Main(string[] args)
    {
        /* //Aufgabe 1
            Console.WriteLine("Enter 2 numbers...");
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            Console.WriteLine("Your numbers were " + a + " and " + b + ".");
            int.TryParse(a, out var c);
            int.TryParse(b, out var d);

            if (c == d) {
                Console.WriteLine("Your numbers are the same. Hooray!");
            }
            else {
                Console.WriteLine("Your numbers are different from each other. :(");
            }
            //Aufgabe 2
            var result = c % d;
            if (result == 0)
            {
                Console.WriteLine("Your numbers are multiples of each other.");
            }
            else
            {
                Console.WriteLine("Your numbers are not multiples of each other.");
            }
                                                                                            */
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