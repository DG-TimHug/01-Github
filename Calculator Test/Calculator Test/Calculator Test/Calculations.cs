namespace Calculator_Test;

public class Calculator(string name)
{
    public double Calculate;
    public string Name = name;

    public void AddNumbers(double selectedNumber1, double selectedNumber2)
    {
        Calculate = selectedNumber1 + selectedNumber2;
    }

    public void SubtractNumbers(double selectedNumber1, double selectedNumber2)
    {
        Calculate = selectedNumber1 - selectedNumber2;
    }

    public void MultiplyNumbers(double selectedNumber1, double selectedNumber2)
    {
        Calculate = selectedNumber1 * selectedNumber2;
    }

    public void DivideNumbers(double selectedNumber1, double selectedNumber2)
    {
        Calculate = selectedNumber1 / selectedNumber2;
    }

    public void ModuloNumber(double selectedNumber1, double selectedNumber2)
    {
        Calculate = selectedNumber1 % selectedNumber2;
    }
}