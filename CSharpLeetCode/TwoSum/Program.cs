using System;

class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();

        for (int index = 0; index < nums.Length; index++)
        {
            int n = nums[index];
            int x = target - n;
            if(hashMap.ContainsKey(x)){
                return new int[] {hashMap[x], index};
            }
            hashMap[n] = index;
        }
        return new int[0];
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        int[] nums1 = {2,7,11,15};
        int target1 = 9;
        int[] result1 = solution.TwoSum(nums1, target1);
        System.Console.WriteLine($"Target1: [{result1[0]},{result1[1]}]");
        
        int[] nums2 = {3,2,4};
        int target2 = 6;
        int[] result2 = solution.TwoSum(nums2, target2);
        System.Console.WriteLine($"Target2: [{result2[0]},{result2[1]}]");
        
        int[] nums3 = {3,3};
        int target3 = 6;
        int[] result3 = solution.TwoSum(nums3, target3);
        System.Console.WriteLine($"Target3: [{result3[0]},{result3[1]}]");
    }
}
