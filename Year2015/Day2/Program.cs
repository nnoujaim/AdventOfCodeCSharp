using Year2015.Day2;

namespace Year2015.Day2;

class Program
{
    static void Main(string[] args)
    {
        var inputs = new List<List<int>> ();
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            var numbers = line.Split('x')
                .Select(int.Parse)
                .ToList();
            inputs.Add(numbers);
        }

        var presents = new PresentCollection();
        presents.Load(inputs);
        var total = presents.GetTotalWrappingPaper();
        var ribbonTotal = presents.GetTotalRibbonLength();
        Console.WriteLine($"Total wrapping paper needed: {total} sqft");
        Console.WriteLine($"Total ribbon length needed: {ribbonTotal} ft");
    }
}
