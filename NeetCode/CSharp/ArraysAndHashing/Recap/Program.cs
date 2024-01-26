namespace ConcatenationOfArray
{
    public class Test
    {
        public static void Main()
        {
            int[] result1 = Solution(new int[] { 2,7,11,15 }, 9);
            Console.WriteLine("[{0}]", string.Join(", ", result1)); //Expected [0,1]
            int[] result2 = Solution(new int[] { 3,2,4 }, 6);
            Console.WriteLine("[{0}]", string.Join(", ", result2)); //Expected [1,2]
            int[] result3 = Solution(new int[] { 3,3 }, 6);
            Console.WriteLine("[{0}]", string.Join(", ", result3)); //Expected [0,1]
        }

        public static int[] Solution(int[] nums, int target)
        {
            Dictionary<int,int> dictionary = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]>target-1){
                    continue;
                }

                int neededNumber = target-nums[i];

                if(dictionary.ContainsKey(neededNumber)){
                    return new int[] {dictionary[neededNumber], i};
                }
                
                if(!dictionary.ContainsKey(nums[i])){
                    dictionary.Add(nums[i], i);
                }
            }

            return new int[] {};
        }
    }
}