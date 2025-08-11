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
        var number1 = Console.ReadLine();
        var number2 = Console.ReadLine();
        Console.WriteLine("Your numbers were " + number1 + "and " + number2);
    }
}