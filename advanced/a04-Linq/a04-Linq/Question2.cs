using System;
using System.Collections.Generic;
using System.Linq;
namespace a04_Linq;

public class Question2
{
    public static void Execute()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        IEnumerable<int> numQuery2 = numbers.Where(num => num % 3 == 0).OrderBy(n => n);
        var sum = numQuery2.Sum();
        Console.WriteLine(sum);
    }
}