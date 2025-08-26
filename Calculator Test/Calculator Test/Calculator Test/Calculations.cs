namespace Calculator_Test;

public class Counter(string name)
{
    public long Count;
    public string Name = name;

    public void AddNumbers(int selectedNumber1, int selectedNumber2)
    {
        Count = selectedNumber1 + selectedNumber2;
    }

    public void SubtractNumbers(int selectedNumber1, int selectedNumber2)
    {
        Count = selectedNumber1 - selectedNumber2;
    }

    public void MultiplyNumbers(int selectedNumber1, int selectedNumber2)
    {
        Count = selectedNumber1 * selectedNumber2;
    }

    public void DivideNumbers(int selectedNumber1, int selectedNumber2)
    {
        Count = selectedNumber1 / selectedNumber2;
    }

    public void ModuloNumber(int selectedNumber1, int selectedNumber2)
    {
        Count = selectedNumber1 % selectedNumber2;
    }
}