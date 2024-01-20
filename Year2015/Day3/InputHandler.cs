using System.Text.RegularExpressions;

namespace Year2015.Day3;

public class InputHandler
{
    private const string PATH_REGEX = "^[\\<\\>\\^v)]+$";

    public static string[] ParseInput(string[] args)
    {
        if (args.Length == 0) throw new Exception("Elf command needs to know how many santas and the path");
        if (args.Length > 1) throw new Exception("Only supply elf command with the number of santas and path (2 arguments separated by space)");

        var parsed = args[0].Split(' ');
        return parsed;
    }

    public static int GetSantaCount(string count)
    {
        return int.Parse(count);
    }

    public static string GetSantasPath(string path)
    {
        path = TrimQuotes(path);
        ValidatePathCharacters(path);
        return path;
    }

    public static string TrimQuotes(string path)
    {
        return path.Trim('"');
    }

    public static void ValidatePathCharacters(string path)
    {
        bool validPath = Regex.IsMatch(path, PATH_REGEX);
        if (!validPath) throw new InvalidSantaPath();
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
