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
           case 3:
           {    var selectedDate = new DateTime(2021, 12, 21, 18, 23, 00, DateTimeKind.Unspecified);
               Question3.Execute(selectedDate);
               break;
           }
           case 4:
           {
               Console.WriteLine("Please run Unit Tests manually");
               break;
           }
       }
    }
}