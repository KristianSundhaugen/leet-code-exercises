public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();

        int[] result1 = solution.GetConcatenation(new int[] { 1, 2, 1 });
        Console.WriteLine("[{0}]", string.Join(", ", result1)); //Expected [1,2,1,1,2,1]
        int[] result2 = solution.GetConcatenation(new int[] { 1, 3, 2, 1 });
        Console.WriteLine("[{0}]", string.Join(", ", result2)); //Expected [1,3,2,1,1,3,2,1]
    }
    public int[] GetConcatenation(int[] nums)
    {
        int[] ans = new int[nums.Length * 2];
        int j = 0;

        for (int i = 0; i < ans.Length; i++)
        {
            if (i > nums.Length - 1)
            {
                i %= j;
            }

            ans[j++] = nums[i];

            if (j == ans.Length)
            {
                return ans;
            }

        }

        return ans;
    }

    public int[] GetConcatenationSimpleSolution(int[] nums)
    {
        int length = nums.Length;
        int[] ans = new int[length * 2];


        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + length] = nums[i];
        }

        return ans;
    }
}