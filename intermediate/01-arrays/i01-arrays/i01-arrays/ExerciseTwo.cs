namespace i01_arrays;

public class ExerciseTwo
{
    public void DoExercise()
    {
        int[] nums = { 20, 30, 40, 50, 800 };

        Console.WriteLine($"This is the normal order:");
        PrintArray(nums);
        
        Console.WriteLine();
        Console.WriteLine($"This is the order reversed.");
        ArrayReverser(nums);
        Console.WriteLine(":)");
    }
    static void PrintArray(int[] array)
    {
        foreach (var num  in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void ArrayReverser(int[] nums)
    {
        for (int i = 0; i < nums.Length / 2; i++)
        {
            (nums[i], nums[nums.Length - i - 1]) = (nums[nums.Length - i - 1], nums[i]);
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}
