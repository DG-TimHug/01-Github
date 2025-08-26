namespace i02_multidimensional_arrays;

public class ExerciseTwo
{
    public static void DoExercise()
    {
        var sum = 0;
        var multiDimensionalArray = new int[2, 2] { { 1, 2, }, { 4, 5 } };
        var answerArray = new int[multiDimensionalArray.GetLength(0)];
        for (var row1 = 0; row1 < multiDimensionalArray.GetLength(0); row1++)
        {
            for (var row2 = 0; row2 < multiDimensionalArray.GetLength(1); row2++)
            {
                sum += multiDimensionalArray[row1, row2];
            }

            answerArray[row1] = sum;
            sum = 0;
        }

        for (var row1 = 0; row1 < multiDimensionalArray.GetLength(0); row1++)
        {
            Console.WriteLine(answerArray[row1]);
        }
    }
}