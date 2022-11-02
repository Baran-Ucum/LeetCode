string s = "MCMXCIV";

RomanValue romanValue = new RomanValue();
Console.WriteLine(romanValue.res(s));

public class RomanValue
{

    public int resultRomanValue(char c)
    {
        switch (c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }

    public int res(string chars)
    {
        int sumRomanValue = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (i + 1 == chars.Length)
            {
                return sumRomanValue += resultRomanValue(chars[i]);
            }
            if (chars[i] == 'I' && chars[i + 1] == 'V')
            {
                sumRomanValue += 4;
                i++;
            }
            else if (chars[i] == 'I' && chars[i + 1] == 'X')
            {
                sumRomanValue += 9;
                i++;
            }
            else if (chars[i] == 'X' && chars[i + 1] == 'L')
            {
                sumRomanValue += 40;
                i++;
            }
            else if (chars[i] == 'X' && chars[i + 1] == 'C')
            {
                sumRomanValue += 90;
                i++;
            }
            else if (chars[i] == 'C' && chars[i + 1] == 'D')
            {
                sumRomanValue += 400;
                i++;
            }
            else if (chars[i] == 'C' && chars[i + 1] == 'M')
            {
                sumRomanValue += 900;
                i++;
            }
            else
            {
                sumRomanValue += resultRomanValue(chars[i]);
            }

        }
        return sumRomanValue;
    }
}


