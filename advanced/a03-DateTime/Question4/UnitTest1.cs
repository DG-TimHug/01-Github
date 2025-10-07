using a03_DateTime;

namespace Question4;

public class Tests
{
    [Test]
    public void TestifCETtoUTCconverterWorksWinterTime()
    {
        //Arrange 
        var selectedDate = new DateTime(2021, 12, 21, 18, 23, 00, DateTimeKind.Unspecified);
        
        // Act
        var outputDate = Question3.Execute(selectedDate);
        var expectedDate = selectedDate.AddHours(-1);
        //Assert
        Assert.That(outputDate, Is.EqualTo(expectedDate), "Result should be SelectedDate minus 1 hour");
    }
    
    [Test]
    public void TestifCETtoUTCconverterWorksSummerTime()
    {
        //Arrange 
        var selectedDate = new DateTime(2021, 6, 22, 16, 23, 00, DateTimeKind.Unspecified);
        
        // Act
        var outputDate = Question3.Execute(selectedDate);
        var expectedDate = selectedDate.AddHours(-2);
        //Assert
        Assert.That(outputDate, Is.EqualTo(expectedDate), "Result should be SelectedDate minus 2 hours");
    }
    
    [Test]
    public void TestifCETtoUTCconverterWorksSummerTimeTest2()
    {
        //Arrange 
        var selectedDate = new DateTime(2025, 5, 13, 6, 25, 00, DateTimeKind.Unspecified);
        
        // Act
        var outputDate = Question3.Execute(selectedDate);
        var expectedDate = selectedDate.AddHours(-2);
        //Assert
        Assert.That(outputDate, Is.EqualTo(expectedDate), "Result should be SelectedDate minus 2 hours");
    }
    
}