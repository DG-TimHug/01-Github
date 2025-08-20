using System.Security.Cryptography;
using static System.Int32;

namespace Calculator_Test;

class Program
{
    private static void Main(string[] args)
    {
        
        while (true)
        {
            var mainCounter = new Counter("Main Counter");
            Console.WriteLine("Hello and Welcome to the Calculator.");
            var selectedOperator = SelectOperator();


            switch (selectedOperator)
            {
                case 1:
                {
                    var selectedNumber1 = SelectNumber1();
                    var selectedNumber2 = SelectNumber2();
                    Console.WriteLine($"You will now be adding {selectedNumber1} to {selectedNumber2}.");
                    mainCounter.AddNumbers(selectedNumber1, selectedNumber2);
                    Console.WriteLine($"The Result is {mainCounter.Count}.");
                    Console.WriteLine("");
                    break;
                }

                case 2:
                {
                    var selectedNumber1 = SelectNumber1();
                    var selectedNumber2 = SelectNumber2();
                    Console.WriteLine($"You will now be subtracting {selectedNumber1} from {selectedNumber2}.");
                    mainCounter.SubtractNumbers(selectedNumber1, selectedNumber2);
                    Console.WriteLine($"The Result is {mainCounter.Count}.");
                    Console.WriteLine("");
                    break;
                }

                case 3:
                {
                    var selectedNumber1 = SelectNumber1();
                    var selectedNumber2 = SelectNumber2();
                    Console.WriteLine($"You will now be multiplying {selectedNumber1} and {selectedNumber2}.");
                    mainCounter.MultiplyNumbers(selectedNumber1, selectedNumber2);
                    Console.WriteLine($"The Result is {mainCounter.Count}.");
                    Console.WriteLine("");
                    break;
                }

                case 4:
                {
                    var selectedNumber1 = SelectNumber1();
                    var selectedNumber2 = SelectNumber2();
                    Console.WriteLine($"You will now be dividing {selectedNumber1} and {selectedNumber2}.");
                    mainCounter.DivideNumbers(selectedNumber1, selectedNumber2);
                    Console.WriteLine($"The Result is {mainCounter.Count}.");
                    Console.WriteLine("");
                    break;
                }

                case 5:
                {
                    var selectedNumber1 = SelectNumber1();
                    var selectedNumber2 = SelectNumber2();
                    Console.WriteLine($"You will now be using Modulo on {selectedNumber1} and {selectedNumber2}");
                    mainCounter.ModuloNumber(selectedNumber1, selectedNumber2);
                    Console.WriteLine($"The Result is {mainCounter.Count}.");
                    Console.WriteLine("");
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
    }

    private static int SelectOperator()
    {
        
        Console.WriteLine("Please enter your operator.");
        Console.WriteLine("1 = Addition");
        Console.WriteLine("2 = Subtraction");
        Console.WriteLine("3 = Multiplication");
        Console.WriteLine("4 = Division");
        Console.WriteLine("5 = Modulo");
        //Console.WriteLine("6 = View Current result in counter");
        TryParse(Console.ReadLine(), out var selectedOperator);
        return selectedOperator;
    }

    private static int SelectNumber1()
    {
        Console.WriteLine("Please enter 2 numbers that you want to complete your Operation with.");
        Console.WriteLine("Your first number please.");
        TryParse(Console.ReadLine(), out var selectedNumber1);
        return selectedNumber1;
    }

    private static int SelectNumber2()
    {
        Console.WriteLine("Your second number please.");
        TryParse(Console.ReadLine(), out var selectedNumber2);
        return selectedNumber2;
    }

    private class Counter
    {
        public int Count;
        public string Name;

        public Counter(string name)
        {
            Name = name;
        }

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
}