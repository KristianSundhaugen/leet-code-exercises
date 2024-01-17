public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.ContainsDuplicate(new int[] { 1, 2, 3, 1 })); //Expected true
        Console.WriteLine(solution.ContainsDuplicate(new int[] { 1, 2, 3, 4 })); //Expected false
        Console.WriteLine(solution.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })); //Expected true
        Console.WriteLine(solution.TopSolutionContainsDuplicate(new int[] { 1, 2, 3, 1 })); //Expected true
        Console.WriteLine(solution.TopSolutionContainsDuplicate(new int[] { 1, 2, 3, 4 })); //Expected false
        Console.WriteLine(solution.TopSolutionContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })); //Expected true
    }
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> countDictionary = new Dictionary<int, int>();

        foreach (int item in nums)
        {
            if (!countDictionary.ContainsKey(item))
            {
                countDictionary.Add(item, 1);
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    public bool TopSolutionContainsDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count < nums.Length;
    }
}