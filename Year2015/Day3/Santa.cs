using System.Collections.Generic;

namespace Year2015.Day3;

public class Santa
{
    private const char TRAVERSE_UP = '^';
    private const char TRAVERSE_DOWN = 'v';
    private const char TRAVERSE_LEFT = '<';
    private const char TRAVERSE_RIGHT = '>';

    public int XLocation { get; set; }
    public int YLocation { get; set; }

    public Santa()
    {
        XLocation = 0;
        YLocation = 0;
    }

    public void Traverse(char p)
    {
        if (p == TRAVERSE_UP) YLocation++;
        if (p == TRAVERSE_DOWN) YLocation--;
        if (p == TRAVERSE_RIGHT) XLocation++;
        if (p == TRAVERSE_LEFT) XLocation--;
    }
}
