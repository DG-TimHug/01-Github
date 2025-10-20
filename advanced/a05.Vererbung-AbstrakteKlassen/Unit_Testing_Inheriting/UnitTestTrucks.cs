using a05.Vererbung_AbstrakteKlassen;
namespace Unit_Testing_Inheriting;

public class UnitTestTrucks
{ 
    [Test]
    public void TestIfTruckCanAccelerate()
    {
        //Arrange
        var TestTruck = new Program.Truck();
        //Act
        TestTruck.Accelerate();
        var Result = TestTruck.Speed;
        //Assert
        Assert.That(Result, Is.EqualTo(2), "Expected is 2");
    }

    [Test]
    public void TestIfTruckCanDecelerate()
    {
        //Arrange
        var TestTruck = new Program.Truck();
        TestTruck.Speed = 2;
        //Act
        TestTruck.Decelerate();
        var Result = TestTruck.Speed;
        //Assert
        Assert.That(Result, Is.EqualTo(0), "Expected is 0");
    }

    [Test]
    public void TestIfTruckCanUpshift()
    {
        //Arrange
        var TestTruck = new Program.Truck();
        TestTruck.Gear = 2;
        //Act
        TestTruck.Upshift(1);
        var Result = TestTruck.Gear;
        //Assert
        Assert.That(Result, Is.EqualTo(3), "Expected is 3");
    }

    [Test]
    public void TestIfTruckCanDownshift()
    {
        //Arrange
        var TestTruck = new Program.Truck();
        TestTruck.Gear = 2;
        //Act
        TestTruck.Downshift(1);
        var Result = TestTruck.Gear;
        //Assert
        Assert.That(Result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfTruckCanLoadCargo()
    {
        //Arrange
        var TestTruck = new Program.Truck();
        //Act
        TestTruck.Loading(16);
        var Result = TestTruck.LoadedWeight;
        //Assert
        Assert.That(Result, Is.EqualTo(16), "Expected is 16");
    }
    
    [Test]
    public void TestIfTruckCanUnloadCargo()
    {
        //Arrange
        var TestTruck = new Program.Truck();
        TestTruck.LoadedWeight = 15;
        //Act
        TestTruck.Unloading(16);
        var Result = TestTruck.LoadedWeight;
        //Assert
        Assert.That(Result, Is.EqualTo(0), "Expected is 0");
    }
}