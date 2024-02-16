namespace Recap
{
    public class Test
    {
        public static void Main()
        {

            int[] result1 = Solution(new int[] { 1, 2, 1 });
            Console.WriteLine("[{0}]", string.Join(", ", result1)); //Expected [1,2,1,1,2,1]
            int[] result2 = Solution(new int[] { 1, 3, 2, 1 });
            Console.WriteLine("[{0}]", string.Join(", ", result2)); //Expected [1,3,2,1,1,3,2,1]
        }

        public static int[] Solution(int[] nums)
        {

            int[] result = new int[nums.Length*2];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[i+nums.Length] = i;
            }

            
            return result;
        }
    }
}