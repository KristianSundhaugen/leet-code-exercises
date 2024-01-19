public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); //Expected true
        Console.WriteLine(solution.IsAnagram("rat", "car")); //Expected false
    }
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        char[] sChars = s.ToLower().ToCharArray();
        char[] tChars = t.ToLower().ToCharArray();

        int[] countLetterArrayS = new int[26];
        int[] countLetterArrayT = new int[26];

        for (int i = 0; i < sChars.Length; i++)
        {
            countLetterArrayS[sChars[i] - 'a']++;
            countLetterArrayT[tChars[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (countLetterArrayS[i] != countLetterArrayT[i])
            {
                return false;
            }
        }

        return true;
    }
}