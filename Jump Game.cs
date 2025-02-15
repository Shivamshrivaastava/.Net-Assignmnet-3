using System;

public class JumpGameProgram
{
    public static bool CanJump(int[] nums)
    {
        int maxReach = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > maxReach) return false;
            maxReach = Math.Max(maxReach, i + nums[i]);
        }
        return true;
    }

    public static void Main()
    {
        int[] nums = { 2, 3, 1, 1, 4 };
        bool result = CanJump(nums);
        Console.WriteLine(result.ToString().ToLower());
    }
}
