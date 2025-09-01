namespace Calculator_Test;

public class ExecOperations
{
    public static void Additon(Counter mainCounter, int selectedNumber1, int selectedNumber2)
    {
        Console.WriteLine($"You will now be adding {selectedNumber1} to {selectedNumber2}.");
        mainCounter.AddNumbers(selectedNumber1, selectedNumber2);
        Console.WriteLine($"The Result is {mainCounter.Count}.");
        Console.WriteLine("");
    }

    public static void Subtraction(Counter mainCounter, int selectedNumber1, int selectedNumber2)
    {
        Console.WriteLine($"You will now be subtracting {selectedNumber1} from {selectedNumber2}.");
        mainCounter.SubtractNumbers(selectedNumber1, selectedNumber2);
        Console.WriteLine($"The Result is {mainCounter.Count}.");
        Console.WriteLine();
    }

    public static void Multiplication(Counter mainCounter, int selectedNumber1, int selectedNumber2)
    {
        Console.WriteLine($"You will now be multiplying {selectedNumber1} and {selectedNumber2}.");
        mainCounter.MultiplyNumbers(selectedNumber1, selectedNumber2);
        Console.WriteLine($"The Result is {mainCounter.Count}.");
        Console.WriteLine();
    }

    public static void Division(Counter mainCounter, int selectedNumber1, int selectedNumber2)
    {
        try
        {
            Console.WriteLine($"You will now be dividing {selectedNumber1} and {selectedNumber2}.");
            mainCounter.DivideNumbers(selectedNumber1, selectedNumber2);
            Console.WriteLine($"The Result is {mainCounter.Count}.");
            Console.WriteLine();
        }
        catch (SystemException ex)
        {
            Console.WriteLine("An error has occured. Please Try again");
            Console.WriteLine();
        }
    }

    public static void Modulo(Counter mainCounter, int selectedNumber1, int selectedNumber2)
    {
        Console.WriteLine($"You will now be using Modulo on {selectedNumber1} and {selectedNumber2}");
        mainCounter.ModuloNumber(selectedNumber1, selectedNumber2);
        Console.WriteLine($"The Result is {mainCounter.Count}.");
        Console.WriteLine();
    }
}

