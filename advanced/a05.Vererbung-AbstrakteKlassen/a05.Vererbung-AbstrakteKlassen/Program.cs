namespace a05.Vererbung_AbstrakteKlassen;
//Frage 8: Es ist zwar eine vererbte Klasse aber sie ist nicht sealed, daher kann man auch Methoden machen, welche nicht in der oberen Klasse sind.
//Abstrakte Klassen: Die Unit-Tests sind nicht mehr gültig da ich Instanzen von der Klasse gemacht habe. Sie sind nicht mehr gültig, weil man keine Instanzen von abstrakten Klassen machen kann
public class Program
{
    static void Main()
    {
        Car timsCar = new Car()
        {
            Speed = 0, Gear = 1, AmountPassengers = 0, AmountSeats = 5, TankContent = 45, TankVolume = 100,
            Owner = "Tim", BuildYear = 2021, Brand = "Volvo", BlinkerSettings = BlinkerSetting.BlinkLeft
        };
        Truck bobsTruck = new Truck()
        {
            Speed = 0, Gear = 1, BuildYear = 2021, LoadedWeight = 6, Owner = "Bob", Brand = "Volvo Truck",
            TankContent = 595, TankVolume = 600, BlinkerSettings = BlinkerSetting.Off
        };
        MotorBike joshuasBike = new MotorBike()
        {
            Speed = 0, Gear = 1, TankContent = 40, TankVolume = 50, BuildYear = 2024, Brand = "Yamaha",
            CurveInclination = 0, Owner = "Joshua", BlinkerSettings = BlinkerSetting.BlinkRight
        };
        Console.WriteLine(timsCar.ToString());
        Console.WriteLine(bobsTruck.ToString());
        Console.WriteLine(joshuasBike.ToString());
    }

    public enum BlinkerSetting
    {
        BlinkLeft,
        BlinkRight,
        Off
    }
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        
        public int Gear { get; set; }
        
        public BlinkerSetting BlinkerSettings {get; set;}
        
        public string Owner { get; set; }
        
        public int BuildYear { get; set; }
        
        public int TankVolume { get; set; }
        
        public int TankContent { get; set; }
        
        public string Brand { get; set; }
        
        public void Accelerate()
        {
            Speed++;
        }

        public void Decelerate()
        {
            if (Speed > 0)
            {
                Speed--;
            }
        }

        public void Upshift(int gear)
        {
            Gear += gear;
        }

        public void Downshift(int gear)
        {
            Gear -= gear;
        }
        public void RefuelCar(int liter)
        {
           TankContent += liter;
        }
    }

    public class Car : Vehicle
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

        public void EmbarkPassengers()
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

        public void DisembarkPassengers()
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

        public override string ToString()
        {
            return $"Current Stats: Owner = {Owner}, Build year and Car Brand = {BuildYear}, {Brand}, Speed = {Speed} Km/h, Gear = {Gear}, Amount Of Passengers = {AmountPassengers}, Amount of Seats = {AmountSeats}, How much Fuel is in the Car? = {TankContent} / {TankVolume}l, Blinkersetting = {BlinkerSettings}";
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

        public void Loading(int addedWeight)
        {
            if (addedWeight >= 25)
            {
                Console.WriteLine("Truck is Full!");
                LoadedWeight = 25;
            }
            else
            {
                LoadedWeight += addedWeight;
            }
        }
        
        public void Unloading(int removedWeight)
        {
            if (removedWeight >= LoadedWeight)
            {
                Console.WriteLine("You cant remove more weight than there is in the truck!");
                LoadedWeight = 0;
            }
            else
            {
                LoadedWeight -= removedWeight;
            }
        }

        public string GetTypeName()
        {
            return "LKW";
        }
        public override string ToString()
        {
            return $"Current Stats: Owner = {Owner}, Build year and Car Brand = {BuildYear}, {Brand}, Speed = {Speed} Km/h, Gear = {Gear}, Amount of Cargo Loaded = {LoadedWeight} t, How much Fuel is in the Car? = {TankContent} / {TankVolume}l, Blinkersetting = {BlinkerSettings}";
        }
    }

    public class MotorBike : Vehicle
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

        public void LeanLeft()
        {
            CurveInclination += -2;
        }

        public void LeanRight()
        {
            CurveInclination += +2;
        }

        public string GetTypeName()
        {
            return "Motorbike";
        }
        public override string ToString()
        {
            return $"Current Stats: Owner = {Owner}, Build-year and Car Brand = {BuildYear}, {Brand}, Speed = {Speed} Km/h, Gear = {Gear}, Current Curve Inclination = {CurveInclination} %, How much Fuel is in the Car? = {TankContent} / {TankVolume}l, Blinkersetting = {BlinkerSettings}";
        }
    }
}