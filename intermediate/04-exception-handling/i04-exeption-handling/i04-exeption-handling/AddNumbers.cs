using static System.Int32;
namespace i04_exeption_handling;

public static class AddNumbers
{
    public static void NumberAdder()
    {
        while(true)
        {
            try
            {
                var sum = 0;
                Console.WriteLine("Enter 2 numbers you want to add.");
                Console.WriteLine("Please enter your first number.");
                if (!TryParse(Console.ReadLine(), out var firstUserinput))
                {
                    throw new ArgumentException("No Vaild Number entered");
                }

                Console.WriteLine("Please enter your second number.");
                if (!TryParse(Console.ReadLine(), out var secondUserInput))
                {
                    throw new ArgumentException("No Vaild Number entered");
                }
                
                try
                {
                    checked
                    {
                        sum = firstUserinput + secondUserInput;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("An error has occured. We are sorry for the inconvenience.");
                }
                Console.WriteLine($"The result is : {sum}");
                Console.WriteLine();
            }
            catch(SystemException)
            {
                Console.WriteLine("An error has occured. We are sorry for the inconvenience.");
                Console.WriteLine();
            }
        }
    }
}