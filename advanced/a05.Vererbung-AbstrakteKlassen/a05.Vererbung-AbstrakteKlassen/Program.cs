namespace a05.Vererbung_AbstrakteKlassen;

class Program
{
    static void Main()
    {
        Car TimsCar = new Car()
        {
            Speed = 0, Gear = 1, AmountPassengers = 0, AmountSeats = 5, TankContent = 45, TankVolume = 100,
            Owner = "Tim", Buildyear = 2021, Brand = "Volvo", BlinkerSetting = BlinkerSetting.off
        };
        Truck BobsTruck = new Truck()
        {
            Speed = 0, Gear = 1, Buildyear = 2021, LoadedWeight = 6, Owner = "Bob", Brand = "Volvo Truck",
            TankContent = 595, TankVolume = 600, BlinkerSetting = BlinkerSetting.off
        };
        MotorBike JoshuasBike = new MotorBike()
        {
            Speed = 0, Gear = 1, TankContent = 40, TankVolume = 50, Buildyear = 2024, Brand = "Yamaha",
            CurveInclination = 0, Owner = "Joshua", BlinkerSetting = BlinkerSetting.BlinkRight
        };

        Console.WriteLine(TimsCar.ToString());
    }
    internal enum BlinkerSetting
    {
        BlinkLeft,
        BlinkRight,
        off
    }
    public class Vehicle
    {
        public int Speed { get; set; }
        
        public int Gear { get; set; }
        
        public BlinkerSetting BlinkerSetting {get; set;}
        
        public string Owner { get; set; }
        
        public int Buildyear { get; set; }
        
        public int TankVolume { get; set; }
        
        public int TankContent { get; set; }
        
        public string Brand { get; set; }
        
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
        public int AmountSeats { get; set; }
        public int AmountPassengers { get; set; }

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
        public int LoadedWeight { get; set; }
        
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
        public int CurveInclination { get; set; }
        
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