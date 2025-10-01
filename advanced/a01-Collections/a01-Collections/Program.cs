namespace a01_Collections;

class Program
{
    static void Main(string[] args)
    {
       /*
        * Listen sind wesentlich flexibler wie Arrays, da man wann man will daten hinzufügen, abrufen, verändern und Löschen kann.
        *
        * Unterschiede zwischen Sets und Listen. Listen sind Geordnete Orte wo ein Wert mehrmals vorkommen kann vs. ein Set ein Ungeordneter Ort ist wo ein Wert nur einmal vorkommen kann.
        */
       List<int> list = new List<int>();
       
       list.Add(10);
       list.Add(25);
       list.Add(15);
       list.Add(10);
    }
}