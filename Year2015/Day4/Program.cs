using System.Security.Cryptography;

namespace Year2015.Day4;

public class Program
{
    static void Main(string[] args)
    {
        var count = int.Parse(args[0]);
        var key = args[1];
        HashHandler handler = new HashHandler();
        var number = handler.GetFirstWithZeros(count, key);
        Console.WriteLine(number);
    }
}
