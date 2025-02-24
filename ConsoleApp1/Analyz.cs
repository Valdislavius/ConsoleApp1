namespace ConsoleApp1;
class Analyz
{
    public int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach(char c in input)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    public int CountConsonants(string input)
    {
        int count = 0;
        string consonants = "bcdfghjklmnpqrstvwxyzBCDFJHJKLMNPQRSTVWXYZ";

        foreach(char c in input)
        {
            if(consonants.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    public int CountDigits(string input)
    {
        int count = 0;

        foreach(char c in input)
        {
            if (char.IsDigit(c))
            {
                count++;
            }
        }

        return count;
    }
}

