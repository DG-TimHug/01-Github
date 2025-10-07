namespace a04_Linq;

public static class Question1
{
    public static void Execute()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        IEnumerable<int> numQuery2 = numbers.Where(num => num % 3 == 0).OrderBy(n => n);

        foreach (int i in numQuery2)
        {
            Console.WriteLine(i + " ");
        }
    }
}