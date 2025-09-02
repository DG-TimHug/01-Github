namespace Calculator_Test;

public class Calculator(string name)
{
    public double Calculate;
    public string Name = name;

    public void AddNumbers(double selectedNumber1, double selectedNumber2)
    {
        Calculate = selectedNumber1 + selectedNumber2;
    }

    public void SubtractNumbers(double selectedNumber1, int selectedNumber2)
    {
        Calculate = selectedNumber1 - selectedNumber2;
    }

    public void MultiplyNumbers(int selectedNumber1, int selectedNumber2)
    {
        Calculate = selectedNumber1 * selectedNumber2;
    }

    public void DivideNumbers(int selectedNumber1, int selectedNumber2)
    {
        Calculate = (double)selectedNumber1 / selectedNumber2;
    }

    public void ModuloNumber(int selectedNumber1, int selectedNumber2)
    {
        Calculate = selectedNumber1 % selectedNumber2;
    }
}