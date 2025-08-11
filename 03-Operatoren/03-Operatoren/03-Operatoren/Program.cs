namespace Operatoren;

class Program
{
    // 03-Operatoren
    public static void Main()
    {
        //Console.WriteLine("Hello, World!");

        // Aufgabe 1
        
        /*
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
        
        
        */
        //Aufgabe 3
        // Was ist das Ergebnis der beiden Beispielen und wieso unterscheiden sich diese? Einfache Mathematik. Punkt vor strich. Bei a wird 3 + 10 (2*5) gerechnet. Bei b wird 5 (3+2) * 5 gerechnet
        /*
        var a = 3 + 2 * 5;   
        var b = (3 + 2) * 5;
        
        Console.WriteLine(a + " and " + b);
        */
        
        //Aufgabe 4
        Console.WriteLine("Which numbers 1-10 can be divided by 3?");
        
        for (var num = 1; num <= 10; num++)
        {
            if (num % 3 != 0)
            {
                Console.WriteLine(" No");
            }
            else
            {
                Console.WriteLine(" yes");
            }
        }
        //Aufgabe 5
        
        
        
    }
    
}   