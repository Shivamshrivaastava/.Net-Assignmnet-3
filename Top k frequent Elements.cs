using System;
using System.Linq;

public class TopKFrequentElementsProgram
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        return nums.GroupBy(x => x)
                   .OrderByDescending(g => g.Count())
                   .Take(k)
                   .Select(g => g.Key)
                   .ToArray();
    }

    public static void Main()
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int[] result = TopKFrequent(nums, 2);
        Console.WriteLine(string.Join(",", result));
    }
}
