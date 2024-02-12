class StringTests
{

    public static void Main(string[] args)
    {
        string sentence = "This is a sentence, hello world";
        string palindrome = "racecar";

        Console.WriteLine(sentence);
        Console.WriteLine(firstWord(sentence));
        Console.WriteLine("Amount of vowels");
        Console.WriteLine(CountVowels(sentence));
        Console.WriteLine("Is not palindrome: " + IsStringPalindrome(sentence));
        Console.WriteLine("Is palindrome: " + IsStringPalindrome(palindrome));
    }

// Extract the first word from a sentence.
    private static string firstWord(string str)
    {
        if (str.Length > 0)
        {

            string[] sentenceArr = str.Split(' ');
            return sentenceArr[0];

        }
        return "";
    }

// Count the number of vowels in a string.
    private static int CountVowels(string str)
    {
        int count = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        string lowerStr = str.ToLower();

        foreach (char ch in lowerStr)
        {
            if (vowels.Contains(ch))
            {
                count++;
            }
        }

        return count;
    }

// Check if a given string is a palindrome (reads the same backward and forward).
    private static bool IsStringPalindrome(string str)
    {
        if (str.Length == 0)
        {
            return false;
        }

        string lowerStr = str.ToLower();

        int i = 0;
        int j = lowerStr.Length - 1;

        while (i <= j)
        {
            if (lowerStr[i] != lowerStr[j])
            {
                return false;
            }
            i++;
            j--;

        }


        return true;
    }
}



