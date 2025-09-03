using I06_Vertiefungsaufgaben.MultiDArrayPrinter;

namespace I06_Vertiefungsaufgaben;

class Program
{
    private static void Main()
    {
        //To Be implemented
        
        while (true)
        {
           
            Console.WriteLine("Choose your question:");
            Console.WriteLine("1 = Multidimensional Array Feelings Checker and Responder.");
            Console.WriteLine("2 = Coming Soon!");
            int.TryParse(Console.ReadLine(), out var selectedOption);
            switch (selectedOption)
            {
                case 1:
                {
                    FeelingsResponder.Responder();
                    break;
                }
                case 2:
                {
                    RunningX.Run();
                    break;
                }
                default:
                {
                    Console.WriteLine("Please choose another option.");
                    break;
                }
            }
        }                                                                                  
    }
}