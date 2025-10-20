using a05.Vererbung_AbstrakteKlassen;
namespace Unit_Testing_Inheriting;

public class UnitTestsMotorbike
{
    [Test]
    public void TestIfMotorbikeCanAccelerate()
    {
        //Arrange
        var TestMotorbike = new Program.MotorBike();
        //Act
        TestMotorbike.Accelerate();
        var Result = TestMotorbike.Speed;
        //Assert
        Assert.That(Result, Is.EqualTo(6), "Expected is 6");
    }

    [Test]
    public void TestIfMotorbikeCanDecelerate()
    {
        //Arrange
        var TestMotorbike = new Program.MotorBike();
        TestMotorbike.Speed = 6;
        //Act
        TestMotorbike.Decelerate();
        var Result = TestMotorbike.Speed;
        //Assert
        Assert.That(Result, Is.EqualTo(0), "Expected is 0");
    }

    [Test]
    public void TestIfMotorbikeCanUpshift()
    {
        //Arrange
        var TestMotorbike = new Program.MotorBike();
        TestMotorbike.Gear = 2;
        //Act
        TestMotorbike.Upshift(1);
        var Result = TestMotorbike.Gear;
        //Assert
        Assert.That(Result, Is.EqualTo(3), "Expected is 3");
    }

    [Test]
    public void TestIfMotorbikeCanDownshift()
    {
        //Arrange
        var TestMotorbike = new Program.MotorBike();
        TestMotorbike.Gear = 2;
        //Act
        TestMotorbike.Downshift(1);
        var Result = TestMotorbike.Gear;
        //Assert
        Assert.That(Result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfMotorbikeCanLeanLeft()
    {
        //Arrange
        var TestMotorbike = new Program.MotorBike();
        //Act
        TestMotorbike.LeanLeft();
        var Result = TestMotorbike.CurveInclination;
        //Assert
        Assert.That(Result, Is.EqualTo(-2), "Expected is -2");
    }
    
    [Test]
    public void TestIfMotorbikeCanLeanRight()
    {
        //Arrange
        var TestMotorbike = new Program.MotorBike();
        //Act
        TestMotorbike.LeanRight();
        var Result = TestMotorbike.CurveInclination;
        //Assert
        Assert.That(Result, Is.EqualTo(2), "Expected is 2");
    }
}