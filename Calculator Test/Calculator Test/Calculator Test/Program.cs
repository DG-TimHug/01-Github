using Calculator_Test;

while (true)
{
    var mainCounter = new Counter("Main Counter");
    Console.WriteLine("Hello and Welcome to the Calculator.");
    var selectedOperator = OpsCenter.SelectOperator();
    
    switch (selectedOperator)
    {
        case 1:
        {
            var selectedNumber1 = OpsCenter.SelectNumber1();
            var selectedNumber2 = OpsCenter.SelectNumber2();
            Console.WriteLine($"You will now be adding {selectedNumber1} to {selectedNumber2}.");
            mainCounter.AddNumbers(selectedNumber1, selectedNumber2);
            Console.WriteLine($"The Result is {mainCounter.Count}.");
            Console.WriteLine("");
            break;
        }

        case 2:
        {
            var selectedNumber1 = OpsCenter.SelectNumber1();
            var selectedNumber2 = OpsCenter.SelectNumber2();
            Console.WriteLine($"You will now be subtracting {selectedNumber1} from {selectedNumber2}.");
            mainCounter.SubtractNumbers(selectedNumber1, selectedNumber2);
            Console.WriteLine($"The Result is {mainCounter.Count}.");
            Console.WriteLine("");
            break;
        }

        case 3:
        {
            var selectedNumber1 = OpsCenter.SelectNumber1();
            var selectedNumber2 = OpsCenter.SelectNumber2();
            Console.WriteLine($"You will now be multiplying {selectedNumber1} and {selectedNumber2}.");
            mainCounter.MultiplyNumbers(selectedNumber1, selectedNumber2);
            Console.WriteLine($"The Result is {mainCounter.Count}.");
            Console.WriteLine("");
            break;
        }

        case 4:
        {
            var selectedNumber1 = OpsCenter.SelectNumber1();
            var selectedNumber2 = OpsCenter.SelectNumber2();
            Console.WriteLine($"You will now be dividing {selectedNumber1} and {selectedNumber2}.");
            mainCounter.DivideNumbers(selectedNumber1, selectedNumber2);
            Console.WriteLine($"The Result is {mainCounter.Count}.");
            Console.WriteLine("");
            break;
        }

        case 5:
        {
            Console.WriteLine("Currently out of Order. Please use another Operation.");
            /*
            var selectedNumber1 = OpsCenter.SelectNumber1();
            var selectedNumber2 = OpsCenter.SelectNumber2();
            Console.WriteLine($"You will now be using Modulo on {selectedNumber1} and {selectedNumber2}");
            mainCounter.ModuloNumber(selectedNumber1, selectedNumber2);
            Console.WriteLine($"The Result is {mainCounter.Count}.");
            */
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