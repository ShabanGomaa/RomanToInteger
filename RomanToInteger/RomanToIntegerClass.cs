namespace RomanToInteger;

internal class RomanToIntegerClass
{
    public int RomanToInt(string s)
    {

        var symbols = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        int currentValue = 0;
        int nextValue = 0;
        int sum = 0;
        var sChars = s.ToCharArray();
        for (int i = 0; i < sChars.Length; i++)
        {
            currentValue = symbols[sChars[i]];
            if (i < sChars.Length - 1)
            {
                nextValue = symbols[sChars[i + 1]];
                if (nextValue > currentValue)
                {
                    sum += nextValue - currentValue;
                    i++;
                }
                else
                {
                    sum += currentValue;
                }
            }
            else
            {
                sum += symbols[sChars[i]];
            }

        }

        return sum;
    }

}
