public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.TopKFrequent(new int[] { 4, 1, 1, 4, 2, 4, 3, 5, 2, 2, 4 }, 2)); //Expected [1,2]
        Console.WriteLine(solution.TopKFrequent(new int[] { 1 }, 1)); //Expected [1]
    }
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] arr = new int[k];
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.ContainsKey(nums[i]))
            {
                dictionary[nums[i]]++;
            }
            else
            {
                dictionary.Add(nums[i], 1);
            }
        }

        var buckets = new List<int>[nums.Length + 1];
        foreach (var key in dictionary.Keys)
        {
            int frequency = dictionary[key];
            if (buckets[frequency] == null)
            {
                buckets[frequency] = new List<int>();
            }
            buckets[frequency].Add(key);
        }

        int i2 = 0;
        for (int i = buckets.Length - 1; i >= 0 && i2 < k; i--)
        {
            if (buckets[i] != null)
            {
                foreach (var num in buckets[i])
                {
                    arr[i2++] = num;
                    if (i2 == k)
                    {
                        break;
                    }
                }
            }
        }

        return arr;
    }
}