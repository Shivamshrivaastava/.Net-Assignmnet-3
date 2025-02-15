using System;

public class Program1
{
    public static int MaxArea(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxArea = 0;

        while (left < right) {
            int width = right - left;
            int minHeight = Math.Min(height[left], height[right]);
            maxArea = Math.Max(maxArea, width * minHeight);

            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }

    public static void Main() {
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int result = MaxArea(height);
        Console.WriteLine(result);
    }
}
