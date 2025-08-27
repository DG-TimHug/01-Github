namespace i01_arrays;

public class ExerciseOne
{
    public void DoExercise()
    {
        int[] nums = { 20, 30, 40, 50, 800 };
        var sum = 0;
        
        foreach (var number in nums)
        {
            sum += number;
        }

        Console.WriteLine($"The result is {sum}.");
    }
}