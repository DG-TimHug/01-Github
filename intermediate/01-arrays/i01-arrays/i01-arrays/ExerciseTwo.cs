namespace i01_arrays;

public class ExerciseTwo
{
    public void DoExercise()
    {
        int[] nums = { 20, 30, 40, 50, 800 };

        Console.WriteLine($"This is the normal order:");
        PrintArray(nums);

        Array.Reverse(nums);
        Console.WriteLine();
        Console.WriteLine($"This is the order reversed.");
        PrintArray(nums);
        Console.WriteLine(":)");
    }
    void PrintArray(int[] array)
    {
        foreach (var nums in array)
        {
            Console.Write(nums + " ");
        }
        Console.WriteLine();
    }
}
