namespace Year2015.Day2.Presents;


public class PresentCollection
{
    private List<Present> Presents { get; }

    public PresentCollection()
    {
        Presents = new List<Present>();
    }

    public void Load(List<List<int>> inputs)
    {
        foreach (List<int> numbers in inputs)
        {
            Presents.Add(new Present(numbers));
        }
    }

    public int GetTotalWrappingPaper()
    {
        var total = 0;
        foreach(Present p in Presents)
        {
            total += p.WrappingPaperNeededSqFt;
        }
        return total;
    }

    public int GetTotalRibbonLength()
    {
        var total = 0;
        foreach(Present p in Presents)
        {
            total += p.RibbonNeededFt;
        }
        return total;
    }
}

public class Present
{
    public List<int> DimList;
    public int WrappingPaperNeededSqFt { get; set; } = 0;
    public int RibbonNeededFt { get; set; } = 0;

    public Present(List<int> dimList)
    {
        DimList = dimList;
        DimList.Sort();
        WrappingPaperNeededSqFt = GetTotalWrappingPaperNeeded();
        RibbonNeededFt = GetTotalRibbonLength();
    }

    public int GetTotalWrappingPaperNeeded()
    {
        // Equation = (2 * l * w) + (2 * w * h) + (2 * h * l) + smallest side
        var lw = DimList[0] * DimList[1];
        var wh = DimList[1] * DimList[2];
        var hl = DimList[2] * DimList[0];
        var smallest = GetSmallest();
        return 2 * lw + 2 * wh + 2 * hl + smallest;
    }

    public int GetTotalRibbonLength()
    {
        // Equation = smallest + smallest + middle + middle + (l * w * h)
        var smallest = GetSmallest();
        var middle = GetMiddle();
        return smallest * 2 + middle * 2 + DimList[0] * DimList[1] * DimList[2];
    }

    public int GetSmallest()
    {
        return DimList[0];
    }

    public int GetMiddle()
    {
        return DimList[1];
    }
}
