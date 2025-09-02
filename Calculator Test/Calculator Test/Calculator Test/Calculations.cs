namespace Calculator_Test;

public class Calculator(string name)
{
    private double result;
    public string Name = name;

    public void AddNumbers(double selectedNumber1, double selectedNumber2)
    {
        result = selectedNumber1 + selectedNumber2;
    }

    public void SubtractNumbers(double selectedNumber1, double selectedNumber2)
    {
        result = selectedNumber1 - selectedNumber2;
    }

    public void MultiplyNumbers(double selectedNumber1, double selectedNumber2)
    {
        result = selectedNumber1 * selectedNumber2;
    }

    public void DivideNumbers(double selectedNumber1, double selectedNumber2)
    {
        result = selectedNumber1 / selectedNumber2;
    }

    public void ModuloNumber(double selectedNumber1, double selectedNumber2)
    {
        result = selectedNumber1 % selectedNumber2;
    }

    public void PrintResult()
    {
        Console.WriteLine($"The result is {result}");
        Console.WriteLine();
    }
}