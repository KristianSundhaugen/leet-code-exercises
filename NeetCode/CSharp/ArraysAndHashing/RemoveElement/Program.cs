public class Solution
{
    public static void Main()
    {

        int result1 = RemoveElement(new int[] { 3,2,2,3 }, 3);
        Console.WriteLine("{0}", result1);
        int result2 = RemoveElement(new int[] { 0,1,2,2,3,0,4,2 }, 2);
        Console.WriteLine("{0}", result2);
        int result3 = RemoveElement(new int[] { 1, 2 }, 2);
        Console.WriteLine("{0}", result3);
    }
    public static int RemoveElement(int[] nums, int val) {
        int l = 0;
        for (int r = 0; r < nums.Length; r++) {
            if (nums[r] != val) {
                nums[l] = nums[r];
                l++;
            }
        }
        return l;
    }
}