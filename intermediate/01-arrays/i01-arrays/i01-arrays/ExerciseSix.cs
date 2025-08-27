using static System.Int32;

namespace i01_arrays;

public class ExerciseSix
{
    public void DoExercise()
    {
        int[] nums = [20, 30, 40, 50, 800];
        PrintArray(nums);
        Console.WriteLine("Please enter a number that you want to add to the array.");
        TryParse(Console.ReadLine(), out var userInput);
        var addedElementToArray = AddElementToArray(nums, userInput);
        PrintArray(addedElementToArray);
    }
    private static int[] AddElementToArray(int[] originalArray, int elementToAdd)
    {
        var newArray = new int[originalArray.Length + 1];
        for (var i = 0; i < originalArray.Length; i++)
        {
            newArray[i] = originalArray[i];
        }

        newArray[newArray.Length - 1] = elementToAdd;

        return newArray;
    }

    private static void PrintArray(int[] array)
    {
        foreach (var nums in array)
        {
            Console.Write(nums + " ");
        }
        Console.WriteLine();
    }
}