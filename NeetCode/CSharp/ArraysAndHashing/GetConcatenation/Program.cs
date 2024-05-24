public class Solution
{
    public static void Main()
    {

        int[] result1 = GetConcatenation(new int[] { 3,2,2,3 });
        Console.WriteLine("{0}", result1);
        int[] result2 = GetConcatenation(new int[] { 0,1,2,2,3,0,4,2 });
        Console.WriteLine("{0}", result2);
        int[] result3 = GetConcatenation(new int[] { 1, 2 });
        Console.WriteLine("{0}", result3);
    }
    public static int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length*2];

        for (int i = 0; i < nums.Length; i++) {
            ans[i] = nums[i];
            ans[i +nums.Length] = nums[i];
        }

        return ans;
    }
}