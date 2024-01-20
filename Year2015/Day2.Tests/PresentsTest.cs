using Year2015.Day2;
using System.Collections.Generic;

namespace Year2015.Day2.Tests;

public class PresentsTest
{
    public static IEnumerable<object[]> TestData => new List<object[]>
    {
        new object[] { new List<List<int>> { new List<int> { 2, 3, 4 }, new List<int> { 1, 1, 10 } }, 48 },
        new object[] { new List<List<int>> { new List<int> { 3, 2, 1 }, new List<int> { 9, 10, 11 } }, 1040 } // 12 + 1028
    };

    [Fact]
    public void TotalWrappingPaperTest()
    {
        var inputs = new List<List<int>> { new List<int> { 2, 3, 4 }, new List<int> { 1, 1, 10 } };
        PresentCollection presents = new PresentCollection();
        presents.Load(inputs);
        var total = presents.GetTotalWrappingPaper();
        Assert.Equal(101, total);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void TotalRibbonTest(List<List<int>> input, int expected)
    {
        PresentCollection presents = new PresentCollection();
        presents.Load(input);
        var total = presents.GetTotalRibbonLength();
        Assert.Equal(expected, total);
    }
}
