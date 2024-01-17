public class Solution
{

    public static void Main()
    {
        Solution solution = new Solution();

        PrintResult(solution.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" })); //Expected true
        PrintResult(solution.GroupAnagrams(new string[] { "" })); //Expected false
        PrintResult(solution.GroupAnagrams(new string[] { "a" })); //Expected true
    }
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            int[] count = new int[26];

            foreach (char c in str)
            {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!anagramGroups.ContainsKey(key))
            {
                anagramGroups.Add(key,new List<string>());
            }

            anagramGroups[key].Add(str);
        }

        return anagramGroups.Values.ToList<IList<string>>();
    }

        private static void PrintResult(IList<IList<string>> result)
    {
        foreach (var group in result)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }

        Console.WriteLine();
    }
}