namespace Calculator_Test;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and Welcome to the Calculator.");
        int selectedOperator = SelectOperator();

        switch (selectedOperator)
        {
            case 1:
        }

    }

    private static int SelectOperator()
    {
        Console.WriteLine("Please enter your operator");
        Console.WriteLine("1 = Addition");
        Console.WriteLine("2 = Subtraction");
        Console.WriteLine("3 = Multiplication");
        Console.WriteLine("4 = Division");
        Console.WriteLine("5 = Modulo");
        //Console.WriteLine("6 = View Current result in counter");
        return SelectOperator();
    }
    
}