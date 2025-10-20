using a05.Vererbung_AbstrakteKlassen;
using NUnit.Framework.Internal;

namespace Unit_Testing_Inheriting;

public class UnitTestsCar
{
    [Test]
    public void TestIfCarCanAccelerate()
    {
        //Arrange
        var TestCar = new Program.Car();
        //Act
        TestCar.Accelerate();
        var Result = TestCar.Speed;
        //Assert
        Assert.That(Result, Is.EqualTo(4), "Expected is 4");
    }

    [Test]
    public void TestIfCarCanDecelerate()
    {
        //Arrange
        var TestCar = new Program.Car();
        TestCar.Speed = 4;
        //Act
        TestCar.Decelerate();
        var Result = TestCar.Speed;
        //Assert
        Assert.That(Result, Is.EqualTo(0), "Expected is 0");
    }

    [Test]
    public void TestIfCarCanUpshift()
    {
        //Arrange
        var TestCar = new Program.Car();
        TestCar.Gear = 2;
        //Act
        TestCar.Upshift(1);
        var Result = TestCar.Gear;
        //Assert
        Assert.That(Result, Is.EqualTo(3), "Expected is 3");
    }

    [Test]
    public void TestIfCarCanDownshift()
    {
        //Arrange
        var TestCar = new Program.Car();
        TestCar.Gear = 2;
        //Act
        TestCar.Downshift(1);
        var Result = TestCar.Gear;
        //Assert
        Assert.That(Result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfCarCanEmbarkPassengers()
    {
        //Arrange
        var TestCar = new Program.Car();
        //Act
        TestCar.EmbarkPassengers();
        var Result = TestCar.AmountPassengers;
        //Assert
        Assert.That(Result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfCarCanDisembarkPassengers()
    {
        //Arrange
        var TestCar = new Program.Car();
        TestCar.AmountPassengers = 1;
        //Act
        TestCar.DisembarkPassengers();
        var Result = TestCar.AmountPassengers;
        //Assert
        Assert.That(Result, Is.EqualTo(0), "Expected is 0");
    }
}