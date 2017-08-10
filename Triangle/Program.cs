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
        for (int i = 2; i < A.Length; i++)
        {
            if (A[i] - A[i - 1] < A[i - 2] && A[i - 1] - A[i - 2] < A[i] && A[i] - A[i - 2] < A[i - 1])
                return 1;
        }
        return 0;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr);
        Console.WriteLine(result);
    }
}