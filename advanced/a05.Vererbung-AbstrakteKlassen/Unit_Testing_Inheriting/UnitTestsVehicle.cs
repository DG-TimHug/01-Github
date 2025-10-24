using a05.Vererbung_AbstrakteKlassen;
namespace Unit_Testing_Inheriting;
//Unit Tests no longer working due to class now being abstract
public class Tests
{
    [Test]
    public void TestIfVehicleCanAccelerate()
    {
        //Arrange
        var testVehicle = new Program.Vehicle();
        //Act
        testVehicle.Accelerate();
        var result = testVehicle.Speed;
        //Assert
        Assert.That(result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfVehicleCanDecelerate()
    {
        //Arrange
        var testVehicle = new Program.Vehicle();
        testVehicle.Speed = 1;
        //Act
        testVehicle.Decelerate();
        var result = testVehicle.Speed;
        //Assert
        Assert.That(result, Is.EqualTo(0), "Expected is 0");
    }
    [Test]
    public void TestIfVehicleCanUpshift()
    {
        //Arrange
        var testVehicle = new Program.Vehicle();
        testVehicle.Gear = 2;
        //Act
        testVehicle.Shift(1);
        var result = testVehicle.Gear;
        //Assert
        Assert.That(result, Is.EqualTo(3), "Expected is 3");
    }
    
    [Test]
    public void TestIfVehicleCanDownshift()
    {
        //Arrange
        var testVehicle = new Program.Vehicle();
        testVehicle.Gear = 2;
        //Act
        testVehicle.Shift(-1);
        var result = testVehicle.Gear;
        //Assert
        Assert.That(result, Is.EqualTo(1), "Expected is 1");
    }
}