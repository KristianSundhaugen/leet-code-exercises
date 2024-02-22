public class Solution
{

    public static void Main()
    {
        PrintResult(Generate(5)); //Expected [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
        PrintResult(Generate(1)); //Expect [[1]]
    }
    public static IList<IList<int>> Generate(int numRows)
    {
        int itr = 1;
        IList<IList<int>> triangle = new List<IList<int>>();
        while (itr <= numRows)
        {
            List<int> row = new List<int>();
            for (int i = 0; i < itr; ++i)
            {
                if (i == 0 || i == itr - 1)
                {
                    row.Add(1);
                }
                else
                {
                    row.Add(triangle[itr - 2][i - 1] + triangle[itr - 2][i]);
                }
            }
            triangle.Add(row);
            ++itr;
        }
        return triangle;
    }

    private static void PrintResult(IList<IList<int>> result)
    {
        foreach (var group in result)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }

        Console.WriteLine();
    }
}