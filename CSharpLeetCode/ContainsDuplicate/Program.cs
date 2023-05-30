using System;
using System.Collections.Generic;

class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        // Test 1
        int[] nums1 = { 1, 2, 3, 1 };
        bool result1 = solution.ContainsDuplicate(nums1);
        Console.WriteLine("Test 1: " + result1); // Output: true

        // Test 2
        int[] nums2 = { 1, 2, 3, 4 };
        bool result2 = solution.ContainsDuplicate(nums2);
        Console.WriteLine("Test 2: " + result2); // Output: false

        // Test 3
        int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        bool result3 = solution.ContainsDuplicate(nums3);
        Console.WriteLine("Test 3: " + result3); // Output: true
    }
}
