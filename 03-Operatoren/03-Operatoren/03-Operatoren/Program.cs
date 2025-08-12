namespace Operatoren;

class Program
{
    // 03-Operatoren
    public static void Main()
    {
        //Console.WriteLine("Hello, World!");

        // Aufgabe 1
        
        
        var rndmNum = 7;                               //rndm_num weil es ist eine Random Number. Ich habe 7 als beispiel genommen jede andere Zahl geht auch
        var rndmNum2 = (rndmNum + rndmNum) * 5;
        Console.WriteLine("Answer = " + rndmNum2);

        // Aufgabe 2
        Console.WriteLine("Give me 2 numbers that can be divided by eachother...");
        var userFirstNumStr = Console.ReadLine();
        var userSecondNumStr = Console.ReadLine();
        Console.WriteLine("Your numbers were " + userFirstNumStr + " and " + userSecondNumStr);
        int.TryParse(userFirstNumStr, out var userFirstNum);
        int.TryParse(userSecondNumStr, out var userSecondNum);

        var result = (userFirstNum / userSecondNum);
        var userCalcRemain = userFirstNum % userSecondNum;
        Console.WriteLine("The answer is " + result + ". " + userCalcRemain + " remain.");
        
        
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