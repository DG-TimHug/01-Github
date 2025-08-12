namespace _05_Loops;

class Program
{
    static void Main(string[] args)
    {
       //Aufgabe 1
       var num = 1;
        do
        {
            var result1 = num + num;
            Console.WriteLine(num);
            num++;

            Console.WriteLine(result1);
        } while (num < 10);


    }
}