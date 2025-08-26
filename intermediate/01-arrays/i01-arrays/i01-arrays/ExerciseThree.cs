namespace i01_arrays;

public class ExerciseThree
{
    public void DoExercise()
    {
        int[] nums = { 20, 30, 40, 50, 800 };

        foreach (var number in nums)
        {
            Console.WriteLine(number * number);
        }
        Console.WriteLine("The numbers get multiplied with themselves.");
    }
}