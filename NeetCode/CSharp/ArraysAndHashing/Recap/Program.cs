namespace ConcatenationOfArray
{
    public class Test
    {
        public static void Main()
        {
            int[] result1 = Solution(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
            Console.WriteLine("[{0}]", string.Join(", ", result1)); //Expected [0,1]
            int[] result2 = Solution(new int[] { 1, 2 }, 2);
            Console.WriteLine("[{0}]", string.Join(", ", result2)); //Expected [1,2]
            int[] result3 = Solution(new int[] { 1 }, 1);
            Console.WriteLine("[{0}]", string.Join(", ", result3)); //Expected [0,1]
        }

        public static int[] Solution(int[] nums, int target)
        {
            Dictionary<int, int> dict = new();

            int[] answer = new int[target];

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            var buckets = new List<int>[nums.Length + 1];

            foreach (int key in dict.Keys)
            {
                int frequency = dict[key];

                if (buckets[frequency] == null)
                {
                    buckets[frequency] = new List<int>();
                }

                buckets[frequency].Add(key);
            }

            int i2 = 0;
            for (int i = buckets.Length -1 ; i >= 0  && i2 < target; i--)
            {
                if (buckets[i] != null)
                {
                    foreach (var item in buckets[i])
                    {
                        answer[i2] = item;
                        if (i2 == target - 1)
                        {
                            return answer;
                        }
                        i2++;
                    }
                }
            }

            return answer;
        }
    }
}