namespace Recap
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(Solution(new string[] { "flower", "flow", "flight" })); //Expected "fl"
            Console.WriteLine(Solution(new string[] { "dog", "racecar", "car" })); //Expect ""
        }

        public static string Solution(string[] s)
        {
            if (s == null || s.Length == 0) return "";

            // Initialize result string and character index
            string result = s[0];
            int charIndex = 0;

            // Find the minimum length of strings in the array
            int maxCharIndex = s[0].Length;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == null) return "";
                maxCharIndex = GetMinimumLength(maxCharIndex, s[i].Length);
            }

            // Iterate over each character until the minimum length
            while (charIndex < maxCharIndex)
            {
                // Get the previous character
                char prevChar = s[0][charIndex];

                // Compare with other strings
                for (int i = 1; i < s.Length; ++i)
                {
                    if (s[i][charIndex] != prevChar)
                    {
                        // If characters don't match, return the common prefix
                        return result.Substring(0, charIndex);
                    }
                }

                // Move to the next character
                ++charIndex;
            }

            // Return the common prefix
            return result.Substring(0, charIndex);
        }

        // Helper method to find the minimum of two numbers
        private static int GetMinimumLength(int a, int b)
        {
            return a < b ? a : b;
        }
    }
}