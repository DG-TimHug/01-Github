namespace a02_enum;

class Program
{
    enum Gender
    {
        Male,
        Female,
        Unknown
    }
    static void Main(string[] args)
    {
        
    }

    private class Person
    {
        private string firstname;
        private string lastname;
        private int age; 
        static object Gender { get; set; }
        private Gender mygender;
        private Person tim = new Person() { firstname = "Tim", lastname = "Hug", age = 15, mygender = Program.Gender.Male };

    }
}