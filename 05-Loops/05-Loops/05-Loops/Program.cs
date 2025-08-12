namespace _05_Loops;

class Program
{
    static void Main(string[] args)
    {
       //Aufgabe 1
    /*   var result = 0;
       for (int num = 1; num <= 10; num++)
       {
           result += num;
       }

       Console.WriteLine("The sum of the numbers 1-10 is " + result + ".");
       
                                                                                */
    /*    //Aufgabe 2
        var result = 0;
        for (int num = 1; num <= 10; num++)
        {if (num % 2 == 0) 
            result += num;
        }

        Console.WriteLine("The sum of all of the even numbers 1-10 is " + result + ".");
                                                                                            */
        //Aufgabe 4
    /*    
        Console.WriteLine("For the number you enter a Pyramid that size will be shown...");
        var userFirstNumStr = Console.ReadLine();
        Console.WriteLine("Your pyramid size is " + userFirstNumStr + ".");
        int.TryParse(userFirstNumStr, out var userFirstNum);
        var pyramid = "";
        for (int levels = 1; levels <= userFirstNum; levels++)
        {
            var space = "";
            var test = (userFirstNum - levels) ;    //calculates amount of spaces needed for Stars
            for (int i = 0; i < test; i++)
            {
                space += " "; //adds spaces appropriate to amount of layers of stars
            }
            pyramid += "* "; //adds star to pyramid amount of times given by user
           
            Console.WriteLine(space + pyramid);
           // Console.WriteLine(test);
                                                                                            */
        
        //Aufgabe 5
        Console.WriteLine("Quiz time: Approximately how many tunnels does Switzerland have?");
        Console.WriteLine("Is it...");
        Console.WriteLine("A: 700 Tunnels?");
        Console.WriteLine("B: 1000 Tunnels?");
        Console.WriteLine("C: 1300 Tunnels?");
        Console.WriteLine("D: 1500 Tunnels?");
        Console.WriteLine("E: 1700 Tunnenls?");
        var userInput = Console.ReadLine();
        var a = false;
        var b = true;
        var c = false;
        var d = false;
        var e = false;
        if (userInput == b)
        while (userInput != true)
        {
            Console.WriteLine("Please try again");
        }


    }
      
    }
}