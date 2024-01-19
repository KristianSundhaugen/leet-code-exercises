public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine($"[{string.Join(", ", solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9))}]"); // Expected [0, 1]
        Console.WriteLine($"[{string.Join(", ", solution.TwoSum(new int[] { 3, 2, 4 }, 6))}]");       // Expected [1, 2]
        Console.WriteLine($"[{string.Join(", ", solution.TwoSum(new int[] { 3, 2, 3 }, 6))}]");          // Expected [0, 1]
        Console.WriteLine($"[{string.Join(", ", solution.TwoSumBestSolution(new int[] { 2, 7, 11, 15 }, 9))}]"); // Expected [0, 1]
        Console.WriteLine($"[{string.Join(", ", solution.TwoSumBestSolution(new int[] { 3, 2, 4 }, 6))}]");       // Expected [1, 2]
        Console.WriteLine($"[{string.Join(", ", solution.TwoSumBestSolution(new int[] { 3, 2, 3 }, 6))}]");          // Expected [0, 1]

    }

    /**
    This implementation has a time complexity of O(n^2), where n is the length of the input array nums. 
    This is because you have nested loops that iterate through all possible pairs of indices. 
    While this solution is straightforward, it may not be the most efficient for large arrays.
    */
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }


        return Array.Empty<int>();

    }

    public int[] TwoSumBestSolution(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            //Find complementary value by taking target an minusing value
            int complement = target - nums[i];

            //Check if Dictionary contains complement value as key
            if (numIndices.ContainsKey(complement))
            {
                //If it does, add value from Dictionary that complement matches and the indicies we are on in loop
                return new int[] { numIndices[complement], i };
            }

            // Add the current number and its index to the hash table
            if (!numIndices.ContainsKey(nums[i]))
            {
                numIndices[nums[i]] = i;
            }
        }

        return new int[] {};

    }
}