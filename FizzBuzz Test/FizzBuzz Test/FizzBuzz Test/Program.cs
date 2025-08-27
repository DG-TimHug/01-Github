namespace FizzBuzz_Test;

class Program
{
    static void Main(string[] args)
    {
        //FizzBuzzSimple();
        //FizzBuzzComplex();
    }

    private static void FizzBuzzComplex()
    {
        for (int number = 1; number <=100; number++)
        {
            var output = "";
            if (number % 3 == 0)
            {
                output += "Fizz";
            }
            if (number % 5 == 0)
            {
                output += "Buzz";
            }
            Console.WriteLine(output == "" ? number : output );
        }
    }

    private static void FizzBuzzSimple()
    {
        for (int number = 1; number <=100; number++)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine($"FizzBuzz ({number})");
            }
            else if (number % 3 == 0 )
            {
                Console.WriteLine($"Fizz ({number})");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine($"Buzz ({number})");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}