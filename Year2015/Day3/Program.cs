using Year2015.Day3;

namespace Year2015.Day3;

class Program
{
    static void Main(string[] args)
    {
        string[] parsed = InputHandler.ParseInput(args);
        var count = InputHandler.GetSantaCount(parsed[0]);
        var path = InputHandler.GetSantasPath(parsed[1]);

        ElfCommand elf = new ElfCommand(count);
        elf.TraverseAndDeliver(path);

        elf.Report();

        // Santa santa = new Santa();
        // santa.TraverseAndDeliver(path);

        // Console.WriteLine($"Presents delivered to a house receiving only one gift: {santa.PresentsDeliveredOnce}");
        // Console.WriteLine($"Presents delivered to a house that already received presents: {santa.ExtraPresentsDelivered}");
        // Console.WriteLine($"Total presents delivered: {santa.TotalPresentsDelivered}");
        // Console.WriteLine($"Total houses visited: {santa.HouseCount}");
    }
}
