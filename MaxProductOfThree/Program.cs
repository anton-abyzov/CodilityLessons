using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {

        Array.Sort(A);
        var max = int.MinValue;
        //for (int i = 2; i < A.Length; i++)
        //{
        var lastIndex = A.Length - 1;
        max = Math.Max(max, A[lastIndex] * A[lastIndex - 1] * A[lastIndex - 2]);
        max = Math.Max(max, A[0] * A[1] * A[lastIndex]);
        //}

        return max;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr);
        Console.WriteLine(result);
    }
}