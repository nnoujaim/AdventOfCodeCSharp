using Year2015.Day4;

namespace Year2015.Day4.Tests;

public class HashHandlerTest
{
    [Fact]
    public void TestHandler()
    {
        HashHandler handler = new HashHandler();
        var number = handler.GetFirstWithZeros(5, "ckczppom");
        Assert.Equal(117946, number);
    }
}
