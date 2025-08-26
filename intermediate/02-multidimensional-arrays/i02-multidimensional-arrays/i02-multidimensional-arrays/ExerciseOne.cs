namespace i02_multidimensional_arrays;

public class ExerciseOne
{
    public static void SumOfAllElements()
    {
        var sum = 0;
        var multiDimensionalArray = new int[5, 2] { { 1, 2, }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
        foreach (int i in multiDimensionalArray)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}