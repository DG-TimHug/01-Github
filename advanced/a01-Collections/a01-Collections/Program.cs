namespace a01_Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the advanced Part of Learn to Code. You are in collections. Which Question would you like to see?");
        Console.WriteLine();
        int.TryParse(Console.ReadLine(), out var userSelection);

        switch (userSelection)
        {
            case 1:
            {
                Question1.Execute();
                break;
            }

            case 2:
            {
                Question2.Execute();
                break;
            }

            case 3:
            {
                Question3.Execute();
                break;
            }

            case 4:
            {
                Question4.Execute();
                break;
            }

            case 5:
            {
                Question5.Execute();
                break;
            }

            case 6:
            {
                Question6.ExchangeCourse();
                break;
            }
            default:
            {
                Console.WriteLine("Please enter a full and valid number");
                break;
            }
        }
    }
}