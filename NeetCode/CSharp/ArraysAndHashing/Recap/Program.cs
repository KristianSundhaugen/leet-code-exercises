namespace ConcatenationOfArray
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(Solution("anagram", "nagaram")); //Expected true
            Console.WriteLine(Solution("rat", "car")); //Expected false
        }

        public static bool Solution(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            string sLower = s.ToLower();
            string tLower = t.ToLower();

            int[] sCharsArray = new int[26];
            int[] tCharsArray = new int[26];

            for(int i = 0; i<sLower.Length; i++){
                sCharsArray[sLower[i]-'a']++;
                tCharsArray[tLower[i]-'a']++;
            }

            for (int i = 0; i < sCharsArray.Length; i++)
            {
                if(sCharsArray[i] != tCharsArray[i]){
                    return false;
                }
            }


            return true;
        }
    }
}