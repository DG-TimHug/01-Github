namespace _05_Loops;

class Program
{
    static void Main(string[] args)
    {
        /*
        //Aufgabe 1
        var result = 0;
        for (var num = 1; num <= 10; num++)
        {
            result += num;
        }

        Console.WriteLine("The sum of the numbers 1-10 is " + result + ".");
                                                                                    */
        /*
        //Aufgabe 2
        var result = 0;
        for (var num = 1; num <= 10; num++)
        {
            if (num % 2 == 0)
            {
                result += num;
            }
        }

        Console.WriteLine("The sum of all the even numbers 1-10 is " + result + ".");
                                                                                     */
        //Aufgabe 4
        /*
        Console.WriteLine("For the number you enter a Pyramid that size will be shown...");
        var userNumStr = Console.ReadLine();
        Console.WriteLine("Your pyramid size is " + userNumStr + ".");
        int.TryParse(userNumStr, out var userNum);
        var pyramid = "";
        for (int levels = 1; levels <= userNum; levels++)
        {
            var space = "";
            var amountStars = (userNum - levels); //calculates amount of spaces needed for Stars
            for (int i = 0; i < amountStars; i++)
            {
                space += " "; //adds spaces appropriate to amount of layers of stars
            }

            pyramid += "* "; //adds star to pyramid amount of times given by user

            Console.WriteLine(space + pyramid);
            // Console.WriteLine(test);
        }
                                                                                                    */
        //Aufgabe 5
        /*
            Console.WriteLine("Quiz time: Approximately how many tunnels does Switzerland have?");
            Console.WriteLine("Is it...");
            Console.WriteLine("A: 700 Tunnels?"); //Shows Users possible answers
            Console.WriteLine("B: 1000 Tunnels?");
            Console.WriteLine("C: 1300 Tunnels?");
            Console.WriteLine("D: 1500 Tunnels?");
            Console.WriteLine("E: 1700 Tunnels?");
            Console.WriteLine("Please answer with the amount of tunnels.");
            int userAnswer; //declares that userAnswer exists
            var numbAttempts = 0;
            if (int.TryParse(Console.ReadLine(), out userAnswer)) //If the Console can be read and converted into integer continue
            {
                numbAttempts++;
                while (userAnswer != 1300) //while the answer from the user isn't 1300 run the script below
                {
                    Console.WriteLine("That is incorrect. Please try again.");
                    int.TryParse(Console.ReadLine(), out userAnswer); //reads and converts user input and checks if while condition is still false
                    numbAttempts++; //counts up number of attempts needed
                }

                Console.WriteLine("Correct! The answer was 1300!"); // once while loop is complete shows user the correct answer
                Console.WriteLine($"You guessed correctly after {numbAttempts} guesses!");
            }
            else
            {
                //if User input could not be converted into string -> ends program and shows no number was entered
                Console.WriteLine("No Number was entered.");
            }
                                                                                    */                                                                          
            //Aufgabe 6 im Conf
            
    }
}