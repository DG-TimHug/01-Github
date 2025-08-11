using System.ComponentModel.Design;

namespace _04_Verzweigungen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 2 numbers");
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        Console.WriteLine("Your numbers were " + a + " and " + b);
        int.TryParse(a, out var c);
        int.TryParse(b, out var d);

        if c = d;
        {
            Console.WriteLine("Hoorah");
        }
        else {
            Console.WriteLine("womp womp");
        }


    }
}