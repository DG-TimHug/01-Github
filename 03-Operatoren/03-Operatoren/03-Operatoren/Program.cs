namespace Operatoren;

class Program
{
    // 03-Operatoren
    public static void Main()
    {
        //Console.WriteLine("Hello, World!");

        // Aufgabe 1
        var a = 7;
        var b = (a + a) * 5;
        Console.WriteLine("Answer = " + b);

        // Aufgabe 2
        Console.WriteLine("Give me 2 numbers that can be divided by eachother...");
        var c = Console.ReadLine();
        var d = Console.ReadLine();
        Console.WriteLine("Your numbers were " + c + " and " + d);
        int.TryParse(c, out var e);
        int.TryParse(d, out var f);

        var result = (e / f);
        var i = e % f;
        Console.WriteLine("The answer is " + result + ". " + i + " remain.");
        
        //Aufgabe 3
    }
}   