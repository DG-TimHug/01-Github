namespace Calculator_Test;

public class ExecOperations
{
    public static void Additon(Calculator mainCalculator, double selectedNumber1, double selectedNumber2)
    {
        Console.WriteLine($"You will now be adding {selectedNumber1} to {selectedNumber2}.");
        mainCalculator.AddNumbers(selectedNumber1, selectedNumber2);
        Console.WriteLine($"The Result is {mainCalculator.Calculate}.");
        Console.WriteLine("");
    }

    public static void Subtraction(Calculator mainCalculator, double selectedNumber1, int selectedNumber2)
    {
        Console.WriteLine($"You will now be subtracting {selectedNumber1} from {selectedNumber2}.");
        mainCalculator.SubtractNumbers(selectedNumber1, selectedNumber2);
        Console.WriteLine($"The Result is {mainCalculator.Calculate}.");
        Console.WriteLine();
    }

    public static void Multiplication(Calculator mainCalculator, int selectedNumber1, int selectedNumber2)
    {
        Console.WriteLine($"You will now be multiplying {selectedNumber1} and {selectedNumber2}.");
        mainCalculator.MultiplyNumbers(selectedNumber1, selectedNumber2);
        Console.WriteLine($"The Result is {mainCalculator.Calculate}.");
        Console.WriteLine();
    }

    public static void Division(Calculator mainCalculator, int selectedNumber1, int selectedNumber2)
    {
        try
        {
            Console.WriteLine($"You will now be dividing {selectedNumber1} and {selectedNumber2}.");
            mainCalculator.DivideNumbers(selectedNumber1, selectedNumber2);
            Console.WriteLine($"The Result is {mainCalculator.Calculate}.");
            Console.WriteLine();
        }
        catch (SystemException)
        {
            Console.WriteLine("An error has occured. Please Try again");
            Console.WriteLine();
        }
    }

    public static void Modulo(Calculator mainCalculator, int selectedNumber1, int selectedNumber2)
    {
        Console.WriteLine($"You will now be using Modulo on {selectedNumber1} and {selectedNumber2}");
        mainCalculator.ModuloNumber(selectedNumber1, selectedNumber2);
        Console.WriteLine($"The Result is {mainCalculator.Calculate}.");
        Console.WriteLine();
    }
}

