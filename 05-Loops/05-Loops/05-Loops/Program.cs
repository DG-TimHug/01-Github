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
        
        Console.WriteLine("For the number you enter a Pyramid that size will be shown...");
        var userFirstNumStr = Console.ReadLine();
        Console.WriteLine("Your pyramid size is " + userFirstNumStr + ".");
        int.TryParse(userFirstNumStr, out var userFirstNum);
        var pyramid = "*";
        for (int levels = 1; levels <= userFirstNum; levels++)
        {
            Console.WriteLine(pyramid);
            for (int level = 1; level <= levels; level++)
            {
                Console.WriteLine("*"*2);
            }

        }
        
        
       // var pyramid= "*";
       // Console.WriteLine(pyramid);

       // var printnout = userFirstNum * pyramid;
    }
}