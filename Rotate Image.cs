using System;

public class RotateImageProgram
{
    public static void Rotate(int[][] matrix)
    {
        int n = matrix.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }

    public static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };

        Rotate(matrix);

        foreach (var row in matrix)
        {
            Console.Write($"[[{string.Join(",", row)}]]");
        }
    }
}
