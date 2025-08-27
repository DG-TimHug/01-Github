namespace i01_arrays;

public class ExerciseFour
{
    public void DoExercise()
    {
        var numbers = new [] { 20, 17, 365, 643, 6643, 0, 23, 7, 4, 8, 335, 23, 5, 6, 2, 35, 6, 8, 34534, 7, 347, 34, 55, 3, 6, 30 };
        int temp;

        for (var num = 0; num <= numbers.Length; num++)
        {
            for (var sort = 0; sort < numbers.Length - 1; sort++)
            {
                if (numbers[sort] > numbers[sort + 1])
                {
                    (numbers[sort], numbers[sort + 1]) = (numbers[sort + 1], numbers[sort]);
                }
            }
        }

        for (var number = 0; number < numbers.Length; number++)
        {
            Console.WriteLine(numbers[number] + " ");   
        }
    }
}