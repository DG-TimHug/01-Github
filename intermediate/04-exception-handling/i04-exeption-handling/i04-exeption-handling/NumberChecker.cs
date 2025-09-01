using static System.Int32;
namespace i04_exeption_handling;

public static class NumberChecker
{
    public static void PositivChecker()
    {
        try
        {
            int num;
            TryParse(Console.ReadLine(), out num);
            if (num < 0)
            {
                throw new ArgumentException("Number is below Zero", nameof(num));
            }
            else
            {
                Console.WriteLine($"The result is {num}");
            }
        }
        catch (SystemException)
        {
            Console.WriteLine("An error has occured.(Below Zero)");
        }
    }
}