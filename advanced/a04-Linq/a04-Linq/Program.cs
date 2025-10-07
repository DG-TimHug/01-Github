namespace a04_Linq;

class Program
{
    static void Main()
    {
       Console.WriteLine("Choose your question 1-6");
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
           {
               Question3.Execute();
               break;
           }
           case 4:
           {
               Question4.Execute();
               break;
           }
           case 5:
           {
               Question5.Execute();
               break;
           }
           case 6:
           {
               Question6.Execute();
               break;
           }
       }
    }
}
