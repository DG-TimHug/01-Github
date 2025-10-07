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

 internal class SingularPerson
{
    private string firstname;
    private string lastname;
    private int age;
    private Gender Gender;
    private SingularPerson tim = new SingularPerson() { firstname = "Tim", lastname = "Hug", age = 15, Gender = Gender.Male };
} 