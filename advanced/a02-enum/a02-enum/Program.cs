namespace a02_enum;

internal static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose your Question 2/3");
        int.TryParse(Console.ReadLine(), out var selectedQuestion);
        switch (selectedQuestion)
        {
            case 2:
            {
                Question2.Execute();
                break;
            }
            case 3:
            {
                Question3.Execute();
                break;
            }
        }
    }
}