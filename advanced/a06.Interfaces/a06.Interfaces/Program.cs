namespace a06.Interfaces;

class Program
{
    static void Main()
    {
        SimpleConsoleWriter writeText = new SimpleConsoleWriter();
        RandomTextWriter WritesText = new RandomTextWriter();
        
    }

    public interface ITextWriter
    {
        void Print(string Text);


        void PrintLine(string Text);

        void PrintLine();
    }

    public class SimpleConsoleWriter : ITextWriter
    {
        public void Print(string Text)
        {
            Console.Write(Text);
        }

        public void PrintLine(string Text)
        {
            Console.WriteLine(Text);
        }

        public void PrintLine()
        {
           Console.WriteLine();
        }
    }

    public class RandomTextWriter
    {
        Random rnd = new Random();
        public ITextWriter TextWriter;

        public void TextWriters(ITextWriter TextWriter1)
        {
            TextWriter = TextWriter1;
        }
        public void SomeNumbers()
        {
            for (int numbers = 0; numbers < 10; numbers++)
            {
                for (int number2 = 0; number2 < 10; number2++)
                {
                    int randomNumber = rnd.Next(1, 1000);
                    TextWriter.PrintLine(randomNumber.ToString());
                }
            }
        }
    }
}