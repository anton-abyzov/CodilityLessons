using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        if (A.Length < 2)
            return -1;

        var minDiff = int.MaxValue;
        var sum = A.Sum();
        var currentSum = A[0];
        for (int pivot = 1; pivot < A.Length; pivot++)
        {
            int leftSum = currentSum;
            int rightSum = sum - currentSum;
            currentSum += A[pivot];
            minDiff = Math.Min(minDiff, Math.Abs(leftSum - rightSum));
        }
        return minDiff;
    }

    public static void Main()
    {
        string[] array = System.Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(array, int.Parse);
        var result = new Solution().solution(arr);
        Console.WriteLine(result);
    }
}