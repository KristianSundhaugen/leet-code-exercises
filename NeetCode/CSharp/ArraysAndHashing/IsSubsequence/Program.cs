namespace Recap
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(Solution("abc", "ahbgdc")); //Expected true
            Console.WriteLine(Solution("axc", "ahbgdc")); //Expected false
        }

        public static bool Solution(string s, string t)
        {
            int i = 0;
            int j = 0;

            while((i < s.Length) && (j < t.Length)){
                if(s[i] == t[j]){
                    i++;
                }
                j++;
            }

            if(i == s.Length){
                return true;
            }

            return false;
        }
    }
}