using System.Security.Cryptography;
using Calculator_Test;

while (true)
{
    var mainCounter = new Counter("Main Counter");
    Console.WriteLine("Hello and Welcome to the Calculator.");
    var selectedOperator = OpsCenter.SelectOperator();
    var selectedNumber1 = OpsCenter.SelectNumber1();
    var selectedNumber2 = OpsCenter.SelectNumber2();
    
    switch (selectedOperator)
    {
        case 1:
        {
            ExecOperations.Additon(mainCounter, selectedNumber1, selectedNumber2);
            break;
        }

        case 2:
        {
            ExecOperations.Subtraction(mainCounter, selectedNumber1, selectedNumber2);
            break;
        }

        case 3:
        {
            ExecOperations.Multiplication(mainCounter, selectedNumber1, selectedNumber2);
            break;
        }

        case 4:
        {
            ExecOperations.Division(mainCounter, selectedNumber1, selectedNumber2);
            break;
        }

        case 5:
        {
            ExecOperations.Modulo(mainCounter, selectedNumber1, selectedNumber2);
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