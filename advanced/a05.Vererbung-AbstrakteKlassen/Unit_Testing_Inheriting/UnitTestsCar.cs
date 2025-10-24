using a05.Vererbung_AbstrakteKlassen;
using NUnit.Framework.Internal;

namespace Unit_Testing_Inheriting;

public class UnitTestsCar
{
    [Test]
    public void TestIfCarCanAccelerate()
    {
        //Arrange
        var testCar = new Program.Car();
        //Act
        testCar.Accelerate();
        var result = testCar.Speed;
        //Assert
        Assert.That(result, Is.EqualTo(4), "Expected is 4");
    }

    [Test]
    public void TestIfCarCanDecelerate()
    {
        //Arrange
        var testCar = new Program.Car();
        testCar.Speed = 4;
        //Act
        testCar.Decelerate();
        var result = testCar.Speed;
        //Assert
        Assert.That(result, Is.EqualTo(0), "Expected is 0");
    }

    [Test]
    public void TestIfCarCanUpshift()
    {
        //Arrange
        var testCar = new Program.Car();
        testCar.Gear = 2;
        //Act
        testCar.Shift(1);
        var result = testCar.Gear;
        //Assert
        Assert.That(result, Is.EqualTo(3), "Expected is 3");
    }

    [Test]
    public void TestIfCarCanDownshift()
    {
        //Arrange
        var testCar = new Program.Car();
        testCar.Gear = 2;
        //Act
        testCar.Shift(-1);
        var result = testCar.Gear;
        //Assert
        Assert.That(result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfCarCanEmbarkPassengers()
    {
        //Arrange
        var testCar = new Program.Car();
        testCar.AmountSeats = 5;
        //Act
        testCar.EmbarkPassengers();
        var result = testCar.AmountPassengers;
        //Assert
        Assert.That(result, Is.EqualTo(1), "Expected is 1");
    }
    
    [Test]
    public void TestIfCarCanDisembarkPassengers()
    {
        //Arrange
        var testCar = new Program.Car();
        testCar.AmountPassengers = 1;
        //Act
        testCar.DisembarkPassengers();
        var result = testCar.AmountPassengers;
        //Assert
        Assert.That(result, Is.EqualTo(0), "Expected is 0");
    }
}