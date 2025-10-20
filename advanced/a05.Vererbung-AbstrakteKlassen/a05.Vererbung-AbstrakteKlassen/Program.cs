namespace a05.Vererbung_AbstrakteKlassen;

class Program
{
    static void Main()
    {

    
    }
    public class Fahrzeug
    {
        public int Speed { get; protected set; }
        
        public int Gear { get; protected set; }
        
        public string BlinkerSetting {get; protected set;}
        
        public string Owner { get; protected set; }
        
        public int Buildyear { get; protected set; }
        
        public int Tankvolume { get; protected set; }
        
        public int TankContent { get; protected set; }
        
        public void Accelerate()
        {
            this.Speed++;
        }

        public void Decelerate()
        {
            if (this.Speed > 0)
            {
                this.Speed--;
            }
        }

        public void GearShifterUp(int Gear)
        {
            if (Gear >= 8)
            {
                
            }
            else
            {
                Gear++;
            }
        }

        public void GearShifterDown(int Gear)
        {
            if (Gear <= -1)
            {
                
            }
            else
            {
                Gear--;
            }
        }
    }
}