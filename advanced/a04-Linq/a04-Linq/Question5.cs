namespace a04_Linq;

public static class Question5
{
    public static void Execute()
    {
        List<Person> group =
        [
            Tim,
            John,
            Joanne,
            Joelie,
            Bob,
            Michael,
            Martha
        ];
        NamePrinter(group);
    }

    private static void NamePrinter(List<Person> people)
    {
        IEnumerable<string> names = people.Select(human => human.Firstname);
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    private static readonly Person Tim = new() { Firstname = "Tim", Lastname = "Hug", Age = 15, Gender = Genders.Male };

    private static readonly Person John = new()
        { Firstname = "John", Lastname = "Walters", Age = 34, Gender = Genders.Male };

    private static readonly Person Joanne = new()
        { Firstname = "Joanne", Lastname = "Bergestien", Age = 48, Gender = Genders.Female };

    private static readonly Person Joelie = new()
        { Firstname = "Joelie", Lastname = "Freisner", Age = 24, Gender = Genders.Unknown };
        
    private static readonly Person Bob = new()
        { Firstname = "Bob", Lastname = "Ross", Age = 72, Gender = Genders.Male };
        
    private static readonly Person Michael = new()
        { Firstname = "Michael", Lastname = "Meier", Age = 36, Gender = Genders.Male };
        
    private static readonly Person Martha = new()
        { Firstname = "Martha", Lastname = "Feldmann", Age = 53, Gender = Genders.Unknown };
    
    public class Person
    {
        public required string Firstname;
        public required string Lastname;
        public int Age;
        public Genders Gender;
    }

    public enum Genders
    {
        Male,
        Female,
        Unknown
    }
}