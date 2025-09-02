namespace Calculator_Test;

public static class ExecOperations
{
    public static void Additon(Calculator calculator, double selectedNumber1, double selectedNumber2)
    {
        Console.WriteLine($"You will now be adding {selectedNumber1} to {selectedNumber2}.");
        calculator.AddNumbers(selectedNumber1, selectedNumber2);
        calculator.PrintResult(calculator);
    }

    public static void Subtraction(Calculator calculator, double selectedNumber1, double selectedNumber2)
    {
        Console.WriteLine($"You will now be subtracting {selectedNumber1} from {selectedNumber2}.");
        calculator.SubtractNumbers(selectedNumber1, selectedNumber2);
        calculator.PrintResult(calculator);
    }

    public static void Multiplication(Calculator calculator, double selectedNumber1, double selectedNumber2)
    {
        Console.WriteLine($"You will now be multiplying {selectedNumber1} and {selectedNumber2}.");
        calculator.MultiplyNumbers(selectedNumber1, selectedNumber2);
        calculator.PrintResult(calculator);
    }

    public static void Division(Calculator calculator, double selectedNumber1, double selectedNumber2)
    {
        try
        {
            Console.WriteLine($"You will now be dividing {selectedNumber1} and {selectedNumber2}.");
            calculator.DivideNumbers(selectedNumber1, selectedNumber2);
            calculator.PrintResult(calculator);
        }
        catch (SystemException)
        {
            Console.WriteLine("An error has occured. Please Try again");
            Console.WriteLine();
        }
    }

    public static void Modulo(Calculator calculator, double selectedNumber1, double selectedNumber2)
    {
        Console.WriteLine($"You will now be using Modulo on {selectedNumber1} and {selectedNumber2}");
        calculator.ModuloNumber(selectedNumber1, selectedNumber2);
        calculator.PrintResult(calculator);
    }
}

