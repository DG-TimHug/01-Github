namespace a02_enum;

public class Question2
{
    public static void GetGreeting()
    {
        Console.WriteLine("Choose your person");
        var selectedPerson = Console.ReadLine();
        var UserPerson = GetPersonInfo(selectedPerson);
        switch (UserPerson.Gender)
        {
            case Genders.Male:
            {
                Console.WriteLine($"Hello Mr. {UserPerson.lastname}");
                break;
            }
            
            case Genders.Female:
            {
                Console.WriteLine($"Hello Ms. {UserPerson.lastname}");
                break;
            }

            case Genders.Unknown:
            {
                Console.WriteLine($"Hello there {UserPerson.firstname} {UserPerson.lastname}");
                break;
            }

            default:
            {
                Console.WriteLine($"Hello there {UserPerson.firstname} {UserPerson.lastname}");
                break;
            }
        }
    }
    
    public static Persons GetPersonInfo(string name)
    {
        if (name == "tim")
        {
            return Persons.Tim;
        }

        if (name == "john")
        {
            return Persons.John;
        }
        if (name == "joanne")
        {
            return Persons.Joanne;
        }
        if (name == "joelie")
        {
            return Persons.Joelie;
        }
        return null;
    }
}
 public enum Genders
   {
       Male,
       Female,
       Unknown
   }

 public class Persons
{
    public string firstname;
    public string lastname;
    private int age;
    public Genders Gender;
    public static Persons Tim = new Persons() { firstname = "Tim", lastname = "Hug", age = 15, Gender = Genders.Male };
    public static Persons John = new Persons() { firstname = "John", lastname = "Walters", age = 34, Gender = Genders.Male };
    public static Persons Joanne = new Persons() { firstname = "Joanne", lastname = "Bergestien", age = 48, Gender = Genders.Female };
    public static Persons Joelie = new Persons() { firstname = "Joelie", lastname = "Freisner", age = 24, Gender = Genders.Unknown };
}

