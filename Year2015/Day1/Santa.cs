using System.Text.RegularExpressions;

namespace Year2015.Day1.Magical;

public class Santa
{
    private const string PATH_REGEX = "^[\\(\\)]+$";
    private const char TRAVERSE_UP_COMMAND = '(';
    private const char TRAVERSE_DOWN_COMMAND = ')';
    public int CurrentFloor { get; set; } = 0;
    public int PositionOfFirstBasementEntry { get; set; } = 0;

    public string? GetSantasPath(string[] args)
    {
        if (args.Length == 0) throw new InvalidSantaPath("No path provided");
        if (args.Length > 1) throw new InvalidSantaPath();

        var path = args[0];
        bool validPath = Regex.IsMatch(path, PATH_REGEX);

        if (!validPath) throw new InvalidSantaPath();

        return path;
    }

    public void TraverseSanta(string path)
    {
        var step = 1;
        foreach (char c in path)
        {
            if (c == TRAVERSE_UP_COMMAND) CurrentFloor ++;
            if (c == TRAVERSE_DOWN_COMMAND) CurrentFloor --;

            if (CurrentFloor < 0 && PositionOfFirstBasementEntry == 0) PositionOfFirstBasementEntry = step;
            step++;
        }
    }

    public string GetDeliveryFloor()
    {
        return $"Santas delivery floor is {CurrentFloor.ToString()}";
    }

    public string GetFirstBasementEntry()
    {
        if (PositionOfFirstBasementEntry == 0) return "Santa never entered the basement";
        return $"Santa entered the basement at step {PositionOfFirstBasementEntry.ToString()}";
    }
}


[Serializable]
public class InvalidSantaPath : Exception
{
    public InvalidSantaPath() : base()
    {
    }

    public InvalidSantaPath(string message) : base(message)
    {
    }

    public InvalidSantaPath(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
