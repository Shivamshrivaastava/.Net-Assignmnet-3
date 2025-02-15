using System;

public class FindMissingNumberProgram
{
    public static int FindMissingNumber(int[] nums)
    {
        int n = nums.Length + 1;
        int sum = n * (n + 1) / 2;
        foreach (int num in nums)
        {
            sum -= num;
        }
        return sum;
    }

    public static void Main()
    {
        int[] nums = { 3, 7, 1, 2, 8, 4, 5 };
        Console.WriteLine(FindMissingNumber(nums));
    }
}
