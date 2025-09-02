using Calculator_Test;

while (true)
{
    var calculator = new Calculator("Main Counter");
    Console.WriteLine("Hello and Welcome to the Calculator.");
    var selectedOperator = StartUp.SelectOperator();
    var selectedNumber1 = StartUp.SelectNumber1();
    var selectedNumber2 = StartUp.SelectNumber2();
    
    switch (selectedOperator)
    {
        case 1:
        {
            ExecOperations.Addition(calculator, selectedNumber1, selectedNumber2);
            break;
        }

        case 2:
        {
            ExecOperations.Subtraction(calculator, selectedNumber1, selectedNumber2);
            break;
        }

        case 3:
        {
            ExecOperations.Multiplication(calculator, selectedNumber1, selectedNumber2);
            break;
        }

        case 4:
        {
            ExecOperations.Division(calculator, selectedNumber1, selectedNumber2);
            break;
        }

        case 5:
        {
            ExecOperations.Modulo(calculator, selectedNumber1, selectedNumber2);
            break;
        }
                
        default:
        {
            Console.WriteLine("Please enter a valid Number.");
            Console.WriteLine("and...");
            Thread.Sleep(3000);
            Console.WriteLine("fuck you");
            Environment.Exit(418);
            break;
        }
    }
}