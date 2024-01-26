namespace ConcatenationOfArray
{
    public class Test
    {
        public static void Main()
        {

            PrintResult(Solution(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" })); //Expected true
            PrintResult(Solution(new string[] { "" })); //Expected false
            PrintResult(Solution(new string[] { "a" })); //Expected true
        }

        public static IList<IList<string>> Solution(string[] strs)
        {
            Dictionary<string, List<string>> anagramGroups = new();

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
                    anagramGroups.Add(key, new List<string>());
                }

                anagramGroups[key].Add(str);
            }

            return anagramGroups.Values.ToList<IList<string>>();
        }
        private static void PrintResult(IList<IList<string>> result)
        {
            foreach (var group in result)
            {
                Console.Write($"[{string.Join(", ", group)}]");
            }

            Console.WriteLine();
        }
    }
}