using System.Net.Mime;

namespace a06.Interfaces;

class Program
{
    static void Main()
    {
        SimpleConsoleWriter writeText = new SimpleConsoleWriter();
        writeText.Print("Bobby Lee");
        writeText.PrintLine("idk");
        writeText.PrintLine();
        writeText.PrintLine(SomeNumbers());
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
            Console.WriteLine(Text);
        }

        public void PrintLine(string Text)
        {
            Console.WriteLine(Text);
        }

        public void PrintLine()
        {
           
        }
    }

    public class RandomTextWriter
    {
        public TextWriter ITextWriter { get; set; }

        public void SomeNumbers()
        {
            for (int numbers = 0; numbers < 10; numbers++)
            {
                
            }
        }
    }
}