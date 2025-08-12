namespace _05_Loops;

class Program
{
    static void Main(string[] args)
    {
       //Aufgabe 1
       var result = 0;
       for (int num = 1; num <= 10; num++)
       {
           result += num;
       }

       Console.WriteLine("The sum of the numbers 1-10 is " + result + ".");

    }
}