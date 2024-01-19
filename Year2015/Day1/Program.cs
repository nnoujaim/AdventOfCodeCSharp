using System;
using Year2015.Day1.Magical;

class Program
{
    static void Main(string[] args)
    {
        Santa santa = new Santa();
        try
        {
            var santasPath = santa.GetSantasPath(args);
            Console.WriteLine($"Santa has been given a valid path");

            santa.TraverseSanta(santasPath);
            Console.WriteLine(santa.GetDeliveryFloor());
            Console.WriteLine(santa.GetFirstBasementEntry());
        }
        catch (InvalidSantaPath e)
        {
            Console.WriteLine("Santa must be given exactly ONE path, consisting of '(' or ')' characters, Error: " + e.Message);
            throw new Exception("Invalid input");
        }
    }
}

