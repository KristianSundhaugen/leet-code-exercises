namespace ConcatenationOfArray
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 1, 2, 3, 1 })); //Expected true
            Console.WriteLine(Solution(new int[] { 1, 2, 3, 4 })); //Expected false
            Console.WriteLine(Solution(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })); //Expected true
        }

        public static bool Solution(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    hash.Add(nums[i]);
                }
            }
            return false;
        }
    }
}