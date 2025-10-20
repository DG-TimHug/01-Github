namespace a05.Vererbung_AbstrakteKlassen;

class Program
{
    static void Main()
    {

    
    }
    public class Vehicle
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

        public void Blinker()
        {
            //?
        }

        public void RefuelCar(int liter)
        {
            this.TankContent += liter;
        }

        public string GetTypeName()
        {
            return null;
        }
    }

    class Car : Vehicle
    {
        public int AmountSeats { get; protected set; }
        public int AmountPassengers { get; protected set; }

        public void accelerate()
        {
            Speed += 4;
        }

        public void decelerate()
        {
            Speed -= 4;
        }

        public void PassengerEnterCar()
        {
            if (AmountPassengers <= AmountSeats)
            {
                AmountPassengers++;
            }
            else
            {
                Console.WriteLine("Car is Full!");
            }
        }

        public void PassengerExitCar()
        {
            if (AmountPassengers >= AmountSeats)
            {
                AmountPassengers--;
            }
            else
            {
                Console.WriteLine("Car is already Empty!");
            }
        }

        public string GetTypeName()
        {
            return "PKW";
        }
    }
}