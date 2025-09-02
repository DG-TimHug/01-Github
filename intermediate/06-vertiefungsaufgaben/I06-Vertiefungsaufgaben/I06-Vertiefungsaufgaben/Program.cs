namespace I06_Vertiefungsaufgaben;

class Program
{
    private static void Main()
    {
        while (true)
        {
            
        
            Console.WriteLine("How are you feeling today?");
            Console.WriteLine("1. Happy");
            Console.WriteLine("2. Sad");
            Console.WriteLine("3. SWISS!");
            int.TryParse(Console.ReadLine(), out var Feelings);

            switch (Feelings)
            {
                case 1:
                {
                    Console.WriteLine("Good Job! Enjoy and have a great rest of your day!");
                    Console.WriteLine();
                    PrintSmileyHappy.Print();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Aww :( Hope you feel better soon.");
                    Console.WriteLine();
                    PrintSmileySad.Print();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("YES!");
                    Console.WriteLine();
                    PrintCross.Print();
                    break;
                }
                default:
                {
                    Console.WriteLine("Since you didnt enter one of the number above heres the template.");
                    Console.WriteLine();
                    Template.PrintTemplate6x9();
                    break;
                }
            }
        }
    }
}