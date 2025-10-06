namespace a02_enum;

public class Question1
{
    
}
 internal enum Gender
   {
       Male,
       Female,
       Unknown
   }

class Person
{
    private string firstname;
    private string lastname;
    private int age;
    private Gender Gender;
    private Person tim = new Person() { firstname = "Tim", lastname = "Hug", age = 15, Gender = Gender.Male };
} 