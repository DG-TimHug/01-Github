namespace a03_DateTime;

static class Program
{
    static void Main()
    {
       Console.WriteLine("Select your Question 1-4");
       Console.WriteLine();
       int.TryParse(Console.ReadLine(), out var selectedQuestion);

       switch (selectedQuestion)
       {
           case 1:
           {
               Question1.Execute();
               break;
           }
           case 2:
           {
               Question2.Execute();
               break;
           }
       }
    }
}