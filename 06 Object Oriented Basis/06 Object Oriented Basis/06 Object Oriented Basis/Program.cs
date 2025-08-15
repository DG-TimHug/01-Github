using System.Diagnostics.CodeAnalysis;

namespace _06_Object_Oriented_Basis;

abstract class Program
{
    private static void Main(string[] args)
    {
        /*
        //Methoden Aufgabe 1
        void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        PrintHelloWorld();
                                        */
        /*
        //Methoden Aufgabe 2
        var userNum1 = 0;
        var userNum2 = 0;

        Console.WriteLine("Please enter 2 numbers.");
        int.TryParse(Console.ReadLine(), out userNum1);
        int.TryParse(Console.ReadLine(), out userNum2);

        bool IsFirstNumGreaterThanSecondNum(int userNum1, int userNum2)
        {
            if (userNum1 > userNum2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Console.WriteLine(IsFirstNumGreaterThanSecondNum(userNum1, userNum2));
                                        */
        //Methoden Aufgabe 3
        /*
        Console.WriteLine("Please write a short sentence.");
        var userInput = Console.ReadLine();

        var output = UserGapCount(userInput);
       Console.WriteLine(output);
    }

    private static int UserGapCount(string userInput)
    {
        var amountSpaces = 0;
        foreach (var singleCharacter in userInput)
        {   
            if (singleCharacter == ' ')
            {
                amountSpaces++;
            }   
        }
        return amountSpaces;
    }
                                    */
        //Klassen Aufgabe 3 (Aufgaben 1/2 bereits während Recherche gelöst. Siehe Conf für mehr info

        //*
        var userCounter1 = new Counter("Counter 1");
        var userCounter2 = new Counter("Counter 2");

        while (true)
        {
            var selectedOption = StartUp();
            switch (selectedOption)
            {
                case 1:
                {
                    var selectCounter = SelectCounter();
                    var userValue = GetUserValue();
                    switch (selectCounter)
                    {
                        case 1:
                        {
                            UpdateCounter(userValue, userCounter1);
                            break;
                        }
                        case 2:
                        {
                            UpdateCounter(userValue, userCounter2);
                            break;
                        }
                    }

                    break;
                }
                case 2:
                {
                    CounterView(userCounter1, userCounter2);
                    break;
                }
                default:
                {
                    Console.WriteLine("Please select a valid number.");
                    break;
                }
            }
        }
                                                    // */
    }

    private class Counter
   {
       public int Count;
       public string Name;
       public Counter(string name)
       {
           Name = name;
       }

       public void AddToCounter(int userNum)
       {
           Count += userNum;
       }
       
       public void SubtractFromCounter(int userNum)
       {
           Count -= userNum;
       }
   }

    private static void UpdateCounter(int userValue, Counter userCounter)
    {
        Console.WriteLine($"{userCounter.Name} selected");
        Console.WriteLine("Enter a number to select your operation");
        Console.WriteLine("1 = Addition");
        Console.WriteLine("2 = Subtraction");
        Console.WriteLine("");
        int.TryParse(Console.ReadLine(), out var operation);
        switch (operation)
        {
            case 1:
                userCounter.AddToCounter(userValue);
                Console.WriteLine($"New Value in {userCounter.Name} is {userCounter.Count}");
                Console.WriteLine("");
                break;
            case 2:
                userCounter.SubtractFromCounter(userValue);
                Console.WriteLine($"New Value in {userCounter.Name} is {userCounter.Count}");
                Console.WriteLine("");
                break;
            default:
                Console.WriteLine("Error 404 Operation not found. Please try again.");
                break;
        }
    }

    private static void CounterView(Counter userCounter1, Counter userCounter2)
    {
        Console.WriteLine("Select a counter you want to view.");
        Console.WriteLine("1 = View Counter 1");
        Console.WriteLine("2 = View Counter 2");
        Console.WriteLine("");
        int.TryParse(Console.ReadLine(), out var viewCounter);
        switch(viewCounter)
        {
            case 1:
            {
                Console.WriteLine($"Current Value in Counter 1 is **{userCounter1.Count}**");
                Console.WriteLine("");
                break;
            }
            case 2:
            {
                Console.WriteLine($"Current Value in Counter 2 is **{userCounter2.Count}**");
                Console.WriteLine("");
                break;
            }
            default:
            {
                Console.WriteLine("Error 404 Counter not found");
                break;
            }
        }
    }

    private static int GetUserValue()
    {
        Console.WriteLine("Enter a number");
        if (int.TryParse(Console.ReadLine(), out var userValue))
        {
            Console.WriteLine($"You have selected {userValue}.");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Error 404. Number not found. Try again");
        }
        return userValue;
    }

    private static int SelectCounter()
    {
        Console.WriteLine("Select a counter you want to add/subtract your number from.");
        Console.WriteLine("1 = Make Changes to Counter 1");
        Console.WriteLine("2 = Make Changes to Counter 2");
        Console.WriteLine("");
        int.TryParse(Console.ReadLine(), out var selectCounter);
        return selectCounter;
    }

    private static int StartUp()
    {
        Console.WriteLine("What do you want to do today?");
        Console.WriteLine("1 = Make Changes to Counters");
        Console.WriteLine("2 = View Values of Counters");
        int.TryParse(Console.ReadLine(), out var selectedOption);
        return selectedOption; 
    }
}