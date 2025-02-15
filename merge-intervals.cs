using System;

public class MergeIntervalsProgram
{
    public static int[][] MergeIntervals(int[][] intervals)
    {
        if (intervals.Length <= 1) return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int[][] result = new int[intervals.Length][];
        int index = 0;

        int[] currentInterval = intervals[0];
        result[index] = currentInterval;

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= currentInterval[1])
            {
                currentInterval[1] = Math.Max(currentInterval[1], intervals[i][1]);
            }
            else
            {
                index++;
                currentInterval = intervals[i];
                result[index] = currentInterval;
            }
        }

        int[][] mergedIntervals = new int[index + 1][];
        Array.Copy(result, mergedIntervals, index + 1);

        return mergedIntervals;
    }

    public static void Main()
    {
        int[][] intervals = new int[][] {
            new int[] { 1, 3 },
            new int[] { 2, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 }
        };

        int[][] result = MergeIntervals(intervals);

        foreach (var interval in result)
        {
            Console.Write($"[[{interval[0]},{interval[1]}]]");
        }
    }
}