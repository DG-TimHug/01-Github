using static System.Int32;

namespace i01_arrays;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to choose a from an Exercise");
        Console.WriteLine("1 = Schreibe eine Methode, die alle Elemente in einem Array zusammenzählt und diese als Summe zurückgibt und rufe diese mit geeigneten Beispielen auf.");
        Console.WriteLine("2 = Schreibe eine Methode, die einen beliebigen Array entgegennimmt und diesen in der umgekehrten Reihenfolge wieder zurückgibt.");
        Console.WriteLine("3 = Schreibe eine Methode, die jedes Element eines Arrays mit Ganzzahlen mit sich selbst multipliziert und als Array in der gleichen Reihenfolge zurückgibt. Benutze dafür foreach.");
        Console.WriteLine("4 = Schreibe eine eigene Sortiermethode (also nicht Sort() benutzen) für einen Ganzzahligen-Array.");
        Console.WriteLine("5 = See Confluence");
        Console.WriteLine("6 = Schreibe eine Methode, mit der du einem Array von Ganzzahlen ein Element hinzufügen kannst. (Tipp: Arrays haben statische Grössen. Die Methode muss zuerst also alle Elemente des übergebenen Arrays in einem grösseren Array speichern und dann die neue Zahl hinzufügen.)");
        
        TryParse(Console.ReadLine(), out var userMenuSelection);
        switch (userMenuSelection)
        {
            case 1:
            {
                var exerciseOne = new ExerciseOne();
                    ExerciseOne.DoExercise();
                break;
            }

            case 2:
            {
                var exerciseTwo = new ExerciseTwo();
                exerciseTwo.DoExercise();
                break;
            }

            case 3:
            {
                var exerciseThree = new ExerciseThree();
                    ExerciseThree.DoExercise();
                break;
            }

            case 4:
            {
                var exerciseFour = new ExerciseFour();
                ExerciseFour.DoExercise();
                break;
            }

            case 6:
            {
                var exerciseSix = new ExerciseSix();
                    ExerciseSix.DoExercise();
                break;
            }

            default:
            {
                Console.WriteLine("Please enter another number");
                break;
            }
        }
    }
}