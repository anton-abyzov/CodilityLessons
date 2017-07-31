using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        if (A.Length == 0)
            return 0;
        var result = 0;
        for (int i = 0; i < A.Length; i++)
        {
            result ^= A[i];
        }
        return result;
    }
}