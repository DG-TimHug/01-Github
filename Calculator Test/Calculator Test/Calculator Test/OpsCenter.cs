using System.Diagnostics.CodeAnalysis;
using static System.Int32;

namespace Calculator_Test;
[SuppressMessage("Performance", "CA1806:Do not ignore method results")]

public static class OpsCenter
{
    public static int SelectOperator()
    {
        Console.WriteLine("Please enter your operator.");
        Console.WriteLine("1 = Addition");
        Console.WriteLine("2 = Subtraction");
        Console.WriteLine("3 = Multiplication");
        Console.WriteLine("4 = Division");
        Console.WriteLine("5 = Modulo");
        TryParse(Console.ReadLine(), out var selectedOperator);
        return selectedOperator;
    }
    
    public static int SelectNumber1()
    {
        Console.WriteLine("Please enter 2 numbers that you want to complete your Operation with.");
        Console.WriteLine("Your first number please.");
        TryParse(Console.ReadLine(), out var selectedNumber1);
        return selectedNumber1;
    }

    public static int SelectNumber2()
    {
        Console.WriteLine("Your second number please.");
        TryParse(Console.ReadLine(), out var selectedNumber2);
        return selectedNumber2;
    }
}