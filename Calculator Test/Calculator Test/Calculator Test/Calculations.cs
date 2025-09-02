namespace Calculator_Test;

public class Calculator(string name)
{
    public double Result;
    public string Name = name;

    public void AddNumbers(double selectedNumber1, double selectedNumber2)
    {
        Result = selectedNumber1 + selectedNumber2;
    }

    public void SubtractNumbers(double selectedNumber1, double selectedNumber2)
    {
        Result = selectedNumber1 - selectedNumber2;
    }

    public void MultiplyNumbers(double selectedNumber1, double selectedNumber2)
    {
        Result = selectedNumber1 * selectedNumber2;
    }

    public void DivideNumbers(double selectedNumber1, double selectedNumber2)
    {
        Result = selectedNumber1 / selectedNumber2;
    }

    public void ModuloNumber(double selectedNumber1, double selectedNumber2)
    {
        Result = selectedNumber1 % selectedNumber2;
    }

    public void PrintResult(Calculator calculator)
    {
        Console.WriteLine($"The result is {calculator.Result}");
        Console.WriteLine();
    }
}