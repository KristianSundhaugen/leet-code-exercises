namespace Recap
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(Solution("Hello World")); //Expected 5
            Console.WriteLine(Solution("   fly me   to   the moon  ")); //Expected 4
            Console.WriteLine(Solution("luffy is still joyboy")); //Expected 6
            Console.WriteLine(BestSolutionWithCShapMethods("Hello World")); //Expected 5
            Console.WriteLine(BestSolutionWithCShapMethods("   fly me   to   the moon  ")); //Expected 4
            Console.WriteLine(BestSolutionWithCShapMethods("luffy is still joyboy")); //Expected 6
        }

        public static int Solution(string s)
        {
            int result = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    result++;
                }

                if (result >= 1 && s[i] == ' ')
                {
                    return result;
                }

            }

            return result;
        }

        public static int BestSolutionWithCShapMethods(string s){
            return s.TrimEnd().Split(' ').Last().Length;
        }
    }
}