using Year2015.Day3;

namespace Year2015.Day3.Tests;

public class ElfCommandTest
{
    [Theory]
    [InlineData(">", 2, 0, 2)]
    [InlineData(">>", 3, 0, 3)]
    [InlineData("<", 2, 0, 2)]
    [InlineData("<>", 2, 1, 3)]
    public void TestSingleSantaDeliversPresents(string path, int once, int extra, int total)
    {
        ElfCommand elf = new ElfCommand(1);
        elf.TraverseAndDeliver(path);

        Assert.Equal(once, elf.PresentsDeliveredOnce);
        Assert.Equal(extra, elf.ExtraPresentsDelivered);
        Assert.Equal(total, elf.TotalPresentsDelivered);
    }

    [Theory]
    [InlineData(">", 2, 1, 3)]
    [InlineData(">>", 2, 2, 4)]
    [InlineData(">^", 3, 1, 4)]
    [InlineData(">^^>", 4, 2, 6)]
    public void TestTwoSantasDeliverPresents(string path, int once, int extra, int total)
    {
        ElfCommand elf = new ElfCommand(2);
        elf.TraverseAndDeliver(path);

        Assert.Equal(once, elf.PresentsDeliveredOnce);
        Assert.Equal(extra, elf.ExtraPresentsDelivered);
        Assert.Equal(total, elf.TotalPresentsDelivered);
    }
}