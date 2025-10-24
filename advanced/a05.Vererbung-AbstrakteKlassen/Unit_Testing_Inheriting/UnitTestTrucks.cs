using a05.Vererbung_AbstrakteKlassen;
namespace Unit_Testing_Inheriting;

public class UnitTestTrucks
{ 
    [Test]
    public void TestIfTruckCanAccelerate()
    {
        //Arrange
        var testTruck = new Program.Truck();
        //Act
        testTruck.Accelerate();
        var result = testTruck.Speed;
        //Assert
        Assert.That(result, Is.EqualTo(2), "Expected is 2");
    }

    [Test]
    public void TestIfTruckCanDecelerate()
    {
        //Arrange
        var testTruck = new Program.Truck();
        testTruck.Speed = 2;
        //Act
        testTruck.Decelerate();
        var result = testTruck.Speed;
        //Assert
        Assert.That(result, Is.EqualTo(0), "Expected is 0");
    }

    [Test]
    public void TestIfTruckCanUpshift()
    {
        //Arrange
        var testTruck = new Program.Truck();
        testTruck.Gear = 2;
        //Act
        testTruck.Shift(1);
        var result = testTruck.Gear;
        //Assert
        Assert.That(result, Is.EqualTo(3), "Expected is 3");
    }

    [Test]
    public void TestIfTruckCanDownshift()
    {
        //Arrange
        var testTruck = new Program.Truck();
        testTruck.Gear = 2;
        //Act
        testTruck.Shift(-1);
        var result = testTruck.Gear;
        //Assert
        Assert.That(result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfTruckCanLoadCargo()
    {
        //Arrange
        var testTruck = new Program.Truck();
        //Act
        testTruck.Loading(16);
        var result = testTruck.LoadedWeight;
        //Assert
        Assert.That(result, Is.EqualTo(16), "Expected is 16");
    }
    
    [Test]
    public void TestIfTruckCanUnloadCargo()
    {
        //Arrange
        var testTruck = new Program.Truck();
        testTruck.LoadedWeight = 15;
        //Act
        testTruck.Unloading(15);
        var result = testTruck.LoadedWeight;
        //Assert
        Assert.That(result, Is.EqualTo(0), "Expected is 0");
        
        //Fails on purpose
    }
}