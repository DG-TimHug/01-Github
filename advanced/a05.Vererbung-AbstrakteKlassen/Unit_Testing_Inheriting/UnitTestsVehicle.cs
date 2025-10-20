using a05.Vererbung_AbstrakteKlassen;
namespace Unit_Testing_Inheriting;

public class Tests
{
    [Test]
    public void TestIfVehicleCanAccelerate()
    {
        //Arrange
        var TestVehicle = new Program.Vehicle();
        //Act
        TestVehicle.Accelerate();
        var Result = TestVehicle.Speed;
        //Assert
        Assert.That(Result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfVehicleCanDecelerate()
    {
        //Arrange
        var TestVehicle = new Program.Vehicle();
        TestVehicle.Speed = 1;
        //Act
        TestVehicle.Decelerate();
        var Result = TestVehicle.Speed;
        //Assert
        Assert.That(Result, Is.EqualTo(0), "Expected is 0");
    }
    [Test]
    public void TestIfVehicleCanUpshift()
    {
        //Arrange
        var TestVehicle = new Program.Vehicle();
        TestVehicle.Gear = 2;
        //Act
        TestVehicle.Upshift(1);
        var Result = TestVehicle.Gear;
        //Assert
        Assert.That(Result, Is.EqualTo(3), "Expected is 3");
    }
    
    [Test]
    public void TestIfVehicleCanDownshift()
    {
        //Arrange
        var TestVehicle = new Program.Vehicle();
        TestVehicle.Gear = 2;
        //Act
        TestVehicle.Downshift(1);
        var Result = TestVehicle.Gear;
        //Assert
        Assert.That(Result, Is.EqualTo(1), "Expected is 1");
    }
}