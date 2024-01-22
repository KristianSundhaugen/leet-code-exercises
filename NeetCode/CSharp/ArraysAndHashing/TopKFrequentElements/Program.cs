public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.TopKFrequent(new int[] { 1 }, 2)); //Expected [1,2]
        Console.WriteLine(solution.TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 1)); //Expected [1]
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

        var pq = new PriorityQueue<int,int>();
        foreach (var key in dictionary.Keys)
        {
            pq.Enqueue(key,dictionary[key]);
            if(pq.Count > k){
                pq.Dequeue();
            }   
        }

        int i2 = k;
        while(pq.Count > 0){
            arr[--i2] = pq.Dequeue();
        }

        return arr;
    }
}