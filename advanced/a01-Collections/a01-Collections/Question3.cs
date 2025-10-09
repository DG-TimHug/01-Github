namespace a01_Collections;

public static class Question3
{
    public static void Execute()
    {
        Console.WriteLine();
        var list = new List<int>();
       
        list.Add(10);
        list.Add(25);
        list.Add(15);
        list.Add(10);

        HashSet<int> MakeHashSet(List<int> temp)
        {
            return temp.ToHashSet();
        }

        Console.WriteLine(String.Join(",", MakeHashSet(list)));
        Console.WriteLine(String.Join(",", list));
    }
}