using System.ComponentModel.Design;
using System.Drawing;

namespace _04_Verzweigungen;

class Program
{
    static void Main(string[] args)
    {
        /*    //Aufgabe 1
           Console.WriteLine("Enter 2 numbers...");
           var userFirstNumStr = Console.ReadLine();
           var UserSecondNumStr = Console.ReadLine();
           Console.WriteLine("Your numbers were " + userFirstNumStr + " and " + UserSecondNumStr + ".");
           int.TryParse(userFirstNumStr, out var userFirstNum);
           int.TryParse(UserSecondNumStr, out var userSecondNum);

           if (userFirstNum == userSecondNum) {
               Console.WriteLine("Your numbers are the same. Hooray!");
           }
           else {
               Console.WriteLine("Your numbers are different from each other. :(");
           }
           //Aufgabe 2
           var result = userFirstNum % userSecondNum;
           if (result == 0)
           {
               Console.WriteLine("Your numbers are multiples of each other.");
           }
           else
           {
               Console.WriteLine("Your numbers are not multiples of each other.");
           }
                                                                                           */
        /*
        //Aufgabe 3                                                                                
        Console.WriteLine("Choose a Color: 1 = Red, 2 = Blue, 3 = Green, 4 = Yellow");
        var userInputStr = Console.ReadLine();
        int.TryParse(userInputStr, out var userInput);

        int userColorSelection = userInput;
        switch (userColorSelection)
        {
            case 1:
                Console.WriteLine("Red");
                break;
            case 2:
                Console.WriteLine("Blue");
                break;
            case 3:
                Console.WriteLine("Green");
                break;
            case 4:
                Console.WriteLine("Yellow");
                break;
            default:
                Console.WriteLine("Error 404 Not Found.");
                break;
        }
                                                                                            */
        //Aufgabe 4
        /*
        Console.WriteLine("Enter 2 numbers...");
        var userThirdNumStr = Console.ReadLine();
        var UserFourthNumStr = Console.ReadLine();
        Console.WriteLine("Your numbers were " + userThirdNumStr + " and " + UserFourthNumStr + ".");
        int.TryParse(userThirdNumStr, out var userThirdNum);
        int.TryParse(UserFourthNumStr, out var userFourthNum);
        
        var resultStr = userThirdNum == userFourthNum ? "Your numbers are the same. Hooray!" : "Your numbers are different from each other. :(";
        Console.WriteLine(resultStr);
                                                                                            */





    }
}