using a05.Vererbung_AbstrakteKlassen;
namespace Unit_Testing_Inheriting;

public class UnitTestsMotorbike
{
    [Test]
    public void TestIfMotorbikeCanAccelerate()
    {
        //Arrange
        var testMotorbike = new Program.MotorBike();
        //Act
        testMotorbike.Accelerate();
        var result = testMotorbike.Speed;
        //Assert
        Assert.That(result, Is.EqualTo(6), "Expected is 6");
    }

    [Test]
    public void TestIfMotorbikeCanDecelerate()
    {
        //Arrange
        var testMotorbike = new Program.MotorBike();
        testMotorbike.Speed = 6;
        //Act
        testMotorbike.Decelerate();
        var result = testMotorbike.Speed;
        //Assert
        Assert.That(result, Is.EqualTo(0), "Expected is 0");
    }

    [Test]
    public void TestIfMotorbikeCanUpshift()
    {
        //Arrange
        var testMotorbike = new Program.MotorBike();
        testMotorbike.Gear = 2;
        //Act
        testMotorbike.Shift(1);
        var result = testMotorbike.Gear;
        //Assert
        Assert.That(result, Is.EqualTo(3), "Expected is 3");
    }

    [Test]
    public void TestIfMotorbikeCanDownshift()
    {
        //Arrange
        var testMotorbike = new Program.MotorBike();
        testMotorbike.Gear = 2;
        //Act
        testMotorbike.Shift(-1);
        var result = testMotorbike.Gear;
        //Assert
        Assert.That(result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfMotorbikeCanLeanLeft()
    {
        //Arrange
        var testMotorbike = new Program.MotorBike();
        //Act
        testMotorbike.LeanLeft();
        var result = testMotorbike.CurveInclination;
        //Assert
        Assert.That(result, Is.EqualTo(-2), "Expected is -2");
    }
    
    [Test]
    public void TestIfMotorbikeCanLeanRight()
    {
        //Arrange
        var testMotorbike = new Program.MotorBike();
        //Act
        testMotorbike.LeanRight();
        var result = testMotorbike.CurveInclination;
        //Assert
        Assert.That(result, Is.EqualTo(2), "Expected is 2");
    }
}