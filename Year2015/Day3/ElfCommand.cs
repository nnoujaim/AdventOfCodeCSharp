namespace Year2015.Day3;

public class ElfCommand
{
    public int SantaCount;
    public List<Santa> Santas;
    public Dictionary<int, Dictionary<int, int>> PresentsMatrix { get; set; }
    public int PresentsDeliveredOnce { get; set; }
    public int ExtraPresentsDelivered { get; set; }
    public int TotalPresentsDelivered {
        get {
            return PresentsDeliveredOnce + ExtraPresentsDelivered;
        }
    }
    public int HouseCount { get; set; }

    public ElfCommand(int count)
    {
        SantaCount = count;
        Santas = new List<Santa> ();
        for (int i = 0; i < count; i++)
        {
            Santas.Add(new Santa());
        }
        PresentsMatrix = new Dictionary<int, Dictionary<int, int>> ();
        InitLocations();
    }

    private void InitLocations()
    {
        PresentsMatrix = new Dictionary<int, Dictionary<int, int>> ();
        EstablishLocation(0, 0);
    }

    // Traverse santas and deliver presents, round robin style
    public void TraverseAndDeliver(string path)
    {
        DeliverInitialPresents();

        int whichSanta = 0;
        foreach (char p in path)
        {
            Santas[whichSanta].Traverse(p);
            var x = Santas[whichSanta].XLocation;
            var y = Santas[whichSanta].YLocation;
            EstablishLocation(x, y);
            RecordDelivery(x, y);

            whichSanta++;
            if (whichSanta >= SantaCount) whichSanta = 0;
        }
    }

    private void DeliverInitialPresents()
    {
        // Record delivery at the starting location
        foreach(Santa s in Santas)
        {
            RecordDelivery(0, 0);
        }
    }

    private void EstablishLocation(int xLocation, int yLocation)
    {
        bool beenHere = true;

        if (!PresentsMatrix.ContainsKey(xLocation))
        {
            PresentsMatrix[xLocation] = new Dictionary<int, int> ();
            PresentsMatrix[xLocation][yLocation] = 0;
            beenHere = false;
        }

        if (!PresentsMatrix[xLocation].ContainsKey(yLocation))
        {
            PresentsMatrix[xLocation][yLocation] = 0;
            beenHere = false;
        }

        if (!beenHere) HouseCount++;
    }

    private void RecordDelivery(int xLocation, int yLocation)
    {
        if (PresentsMatrix[xLocation][yLocation] == 0) PresentsDeliveredOnce++;
        if (PresentsMatrix[xLocation][yLocation] > 0) ExtraPresentsDelivered++;
        PresentsMatrix[xLocation][yLocation]++;
    }

    public void Report()
    {
        Console.WriteLine($"Presents delivered to a house receiving only one gift: {PresentsDeliveredOnce}");
        Console.WriteLine($"Presents delivered to a house that already received presents: {ExtraPresentsDelivered}");
        Console.WriteLine($"Total presents delivered: {TotalPresentsDelivered}");
    }
}
