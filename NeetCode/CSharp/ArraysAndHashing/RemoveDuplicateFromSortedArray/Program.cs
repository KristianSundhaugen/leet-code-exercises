public class Solution
{
    public static void Main()
    {

        int result1 = RemoveDuplicates(new int[] { 1, 1, 2 });
        Console.WriteLine("{0}", result1);
        int result2 = RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
        Console.WriteLine("{0}", result2);
        int result3 = RemoveDuplicates(new int[] { 1, 2 });
        Console.WriteLine("{0}", result3);
    }
    public static int RemoveDuplicates(int[] nums)
    {
        int l = 1;

        if (nums.Length == 1){
            return l;
        }

        for (int r = 1; r < nums.Length; r++){
            if (nums[r] != nums[r-1]){
                nums[l] = nums[r];
                l++;
            }
        }

        return l;
        
    }
}