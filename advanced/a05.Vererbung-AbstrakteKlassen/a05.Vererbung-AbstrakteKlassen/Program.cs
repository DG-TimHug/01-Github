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

        public void GearShifterUp(int gear)
        {
            if (gear >= 8)
            {
                
            }
            else
            {
                gear++;
            }
        }

        public void GearShifterDown(int gear)
        {
            if (gear <= -1)
            {
                
            }
            else
            {
                gear--;
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

        public void Accelerate()
        {
            Speed += 4;
        }

        public void Decelerate()
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

    public class Truck : Vehicle
    {
        public int LoadedWeight { get; protected set; }
        
        public void Accelerate()
        {
            Speed += 2;
        }

        public void Decelerate()
        {
            Speed -= 2;
        }

        public void Loading(int addedweight)
        {
            if (LoadedWeight + addedweight >= 25)
            {
                Console.WriteLine("Truck is Full!");
            }
            else
            {
                LoadedWeight += addedweight;
            }
        }
        
        public void Unloading(int addedweight)
        {
            if (LoadedWeight <= 0)
            {
                Console.WriteLine("Truck is Empty!");
            }
            else
            {
                LoadedWeight -= addedweight;
            }
        }

        public string GetTypeName()
        {
            return "LKW";
        }
    }

    class MotorBike : Vehicle
    {
        public int CurveInclination { get; protected set; }
        
        public void Accelerate()
        {
            Speed += 6;
        }

        public void Decelerate()
        {
            Speed -= 6;
        }

        public void Left()
        {
            CurveInclination -= -2;
        }

        public void Right()
        {
            CurveInclination += +2;
        }

        public string GetTypeName()
        {
            return "Motorbike";
        }
    }
}