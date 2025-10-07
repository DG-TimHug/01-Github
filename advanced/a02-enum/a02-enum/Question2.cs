namespace a02_enum;

internal static class Question2
{
    public static void Execute()
    {
        List<Person> group =
        [
            Tim,
            John,
            Joanne,
            Joelie
        ];
        GetGreeting(group);
    }

    private static void GetGreeting(List<Person> group)
    {
        foreach (var userPerson in group)
        {
            switch (userPerson.Gender)
            {
                case Genders.Male:
                {
                    Console.WriteLine($"Hello Mr. {userPerson.Lastname}.");
                    break;
                }
            
                case Genders.Female:
                {
                    Console.WriteLine($"Hello Ms. {userPerson.Lastname}.");
                    break;
                }
            
                case Genders.Unknown:
                {
                    Console.WriteLine($"Hello there {userPerson.Firstname}.");
                    break;
                }
            }
        } 
            
    }

    private static readonly Person Tim = new Person() { Firstname = "Tim", Lastname = "Hug", Age = 15, Gender = Genders.Male };

    private static readonly Person John = new Person()
        { Firstname = "John", Lastname = "Walters", Age = 34, Gender = Genders.Male };

    private static readonly Person Joanne = new Person()
        { Firstname = "Joanne", Lastname = "Bergestien", Age = 48, Gender = Genders.Female };

    private static readonly Person Joelie = new Person()
        { Firstname = "Joelie", Lastname = "Freisner", Age = 24, Gender = Genders.Unknown };


    

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