namespace Operatoren;

class Program
{
    // 03-Operatoren
    public static void Main()
    {
        //Console.WriteLine("Hello, World!");

        // Aufgabe 1
        
        
        var rndm_num = 7;                               //rndm_num weil es ist eine Random Number. Ich habe 7 als beispiel genommen jede andere Zahl geht auch
        var rndm_num2 = (rndm_num + rndm_num) * 5;
        Console.WriteLine("Answer = " + rndm_num2);

        // Aufgabe 2
        Console.WriteLine("Give me 2 numbers that can be divided by eachother...");
        var user_num1 = Console.ReadLine();
        var user_num2 = Console.ReadLine();
        Console.WriteLine("Your numbers were " + user_num1 + " and " + user_num1);
        int.TryParse(user_num1, out var user_num1_trans);
        int.TryParse(user_num2, out var user_num2_trans);

        var result = (user_num1_trans / user_num2_trans);
        var i = user_num1_trans % user_num2_trans;
        Console.WriteLine("The answer is " + result + ". " + i + " remain.");
        
        
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

    }
    
}   