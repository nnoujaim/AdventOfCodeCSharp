namespace Year2015.Day4;

public class HashHandler()
{
    public int CurrentNumber {get; set; } = 0;

    public int GetFirstWithZeros(int countZeroes, string input)
    {
        bool satisfied = false;
        while (satisfied != true)
        {
            var key = input + CurrentNumber;
            var hash = HashUtility.GetMd5Hash(key);

            var zeroes = CountFirstZeroes(hash);
            if (zeroes >= countZeroes)
            {
                satisfied = true;
            }
            else
            {
                CurrentNumber++;
            }
        }

        return CurrentNumber;
    }

    private int CountFirstZeroes(string hash)
    {
        var foundZeroes = 0;
        foreach (char c in hash)
        {
            if (c == '0')
            {
                foundZeroes++;
            }
            else
            {
                return foundZeroes;
            }
        }
        return foundZeroes;
    }
}
