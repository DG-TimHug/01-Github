using static System.Int32;
namespace i04_exeption_handling;

public class AddNumbers
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
                if (TryParse(Console.ReadLine(), out var firstUserinput))
                {
                    
                }
                else
                {
                    throw new ArgumentException("No Vaild Number entered");
                }

                Console.WriteLine("Please enter your second number.");
                if (TryParse(Console.ReadLine(), out var secondUserInput))
                {
                    
                }
                else
                {
                    throw new ArgumentException("No Vaild Number entered");
                }

                sum = firstUserinput + secondUserInput;
                Console.WriteLine($"The result is : {sum}");
            }
            catch(SystemException exception) 
            {
                Console.WriteLine("An error has occured. We are sorry for the inconvenience.");                
            }
        }
    }
}