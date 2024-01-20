using Year2015.Day1;

namespace Year2015.Day1.Tests;

public class SantaTest
{
    [Theory]
    [InlineData("(", 1, 0)]
    [InlineData(")", -1, 1)]
    [InlineData("))))))(", -5, 1)]
    [InlineData("(())))))(", -3, 5)]
    [InlineData("((()(((((", 7, 0)]
    public void SantaTraversalTest(string path, int deliveryFloor, int basementEntry)
    {
        Santa santa = new Santa();
        santa.TraverseSanta(path);
        Assert.Equal(deliveryFloor, santa.CurrentFloor);
        Assert.Equal(basementEntry, santa.PositionOfFirstBasementEntry);
    }
}