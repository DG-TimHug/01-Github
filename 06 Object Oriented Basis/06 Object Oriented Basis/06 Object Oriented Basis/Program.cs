using System.Numerics;
using System.Runtime.InteropServices.JavaScript;

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
        int userNum1 = 0;
        int userNum2 = 0;

        Console.WriteLine("Please enter 2 numbers.");
        int.TryParse(Console.ReadLine(), out userNum1);
        int.TryParse(Console.ReadLine(), out userNum2);

        bool NumberChecker(int userNum1, int userNum2)
        {
            if(userNum1 > userNum2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Console.WriteLine(NumberChecker(userNum1, userNum2));
                                        */
        //Methoden Aufgabe 3
        /*
        Console.WriteLine("Please write a short sentence.");
        var userInput = Console.ReadLine();

        var output = GapCounter(userInput);
       Console.WriteLine(output);
    }

    private static int GapCounter(string userInput)
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
        Console.WriteLine("Enter 2 numbers. We will add them to each other and also subtract them from each other");
        int.TryParse(Console.ReadLine(), out int userNum);
        var counter1 = new Counter();
        Console.WriteLine(counter1.Count);
        int count = counter1.Count;

    }


    public class Counter 
       {
           /*int.TryParse(Console.ReadLine(), out int userNum1);
           int.TryParse(Console.ReadLine(), out int userNum2); */
           public int Count = 0;
           
           public void AddToCounter(int userNum)
           {
               var additionToCount = Count + userNum;
           }

           public void SubtractFromCounter(int userNum)
           {
               var subtractionToCount = userNum - Count;
           }
       }
    }                

