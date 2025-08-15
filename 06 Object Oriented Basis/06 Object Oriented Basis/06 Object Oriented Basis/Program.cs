namespace _06_Object_Oriented_Basis;

abstract class Program
{
    static void Main(string[] args)
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
        var userCounter1 = new Counter();
        var userCounter2 = new Counter();

        while (true)
        {
            Console.WriteLine("What do you want to do today?");
            Console.WriteLine("1 = Make Changes to Counters");
            Console.WriteLine("2 = View Values of Counters");
            int.TryParse(Console.ReadLine(), out var selectedOption);

            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine("Enter a number");
                    if (int.TryParse(Console.ReadLine(), out var userValue))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Error 404. Number not found. Try again");
                        continue;
                    }
                    Console.WriteLine("Select a counter you want to add/subtract your number from.");
                    Console.WriteLine("1 = Make Changes to Counter 1");
                    Console.WriteLine("2 = Make Changes to Counter 2");
                    int.TryParse(Console.ReadLine(), out var selectCounter);
                    switch (selectCounter)
                    {
                        case 1:
                        {
                            UpdateCounter1(userValue, userCounter1);
                            break;
                        }
                        case 2:
                        {
                            UpdateCounter2(userValue, userCounter2);
                            break;
                        }
                    }
                    break;
                
                case 2:
                    {
                        Console.WriteLine("Select a counter you want to view.");
                        Console.WriteLine("1 = View Counter 1");
                        Console.WriteLine("2 = View Counter 2");
                        int.TryParse(Console.ReadLine(), out var viewCounter);
                        switch(viewCounter)
                        {
                            case 1:
                            {
                                Console.WriteLine($"Current Value in Counter 1 is **{userCounter1.Count}**");
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine($"Current Value in Counter 2 is **{userCounter2.Count}**");
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Error 404 Counter not found");
                                break;
                            }
                        }
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

       public void AddToCounter(int userNum)
       {
           Count += userNum;
       }
       
       public void SubtractFromCounter(int userNum)
       {
           Count -= userNum;
       }
   }

    private static void UpdateCounter1(int userValue, Counter userCounter1)
    {
        Console.WriteLine("Counter 1 selected");
        Console.WriteLine("Enter a number to select your operation");
        Console.WriteLine("1 = Addition");
        Console.WriteLine("2 = Subtraction");
        int.TryParse(Console.ReadLine(), out var operation);
        switch (operation)
        {
            case 1:
                userCounter1.AddToCounter(userValue);
                Console.WriteLine($"New Value in Counter 1 is {userCounter1.Count}");
                break;
            case 2:
                userCounter1.SubtractFromCounter(userValue);
                Console.WriteLine($"New Value in Counter 1 is {userCounter1.Count}");
                break;
            default:
                Console.WriteLine("Error 404 Operation not found. Please try again.");
                break;
        }
    }

    private static void UpdateCounter2(int userValue, Counter userCounter2)
    {
        Console.WriteLine("Counter 2 selected");
        Console.WriteLine("Enter a number to select your operation");
        Console.WriteLine("1 = Addition");
        Console.WriteLine("2 = Subtraction");
        int.TryParse(Console.ReadLine(), out var operation);
        switch (operation)
        {
            case 1:
                userCounter2.AddToCounter(userValue);
                Console.WriteLine($"New Value in Counter 2 is {userCounter2.Count}");
                break;
            case 2:
                Console.WriteLine($"New Value in Counter 2 is {userCounter2.Count}");
                userCounter2.SubtractFromCounter(userValue);
                break;
            default:
                Console.WriteLine("Error 404 Operation not found. Please try again.");
                break;
        }
    }
}