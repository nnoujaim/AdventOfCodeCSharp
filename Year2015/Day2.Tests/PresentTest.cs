using Year2015.Day2;

namespace Year2015.Day2.Tests;

public class PresentTest
{
    [Theory]
    [InlineData(2, 3, 4, 58)]
    [InlineData(1, 1, 10, 43)]
    public void TotalWrappingPaperTest(int length, int width, int height, int total)
    {
        List<int> inputs = new List<int> {length, width, height};
        Present present = new Present(inputs);
        Assert.Equal(total, present.GetTotalWrappingPaperNeeded());
    }

    [Theory]
    [InlineData(2, 3, 4, 34)]
    [InlineData(1, 1, 10, 14)]
    public void TotalRibbonLengthTest(int length, int width, int height, int total)
    {
        List<int> inputs = new List<int> {length, width, height};
        Present present = new Present(inputs);
        Assert.Equal(total, present.GetTotalRibbonLength());
    }
}
