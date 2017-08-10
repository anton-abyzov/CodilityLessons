using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int[] solution(int N, int[] A)
    {
        if (A.Length == 1)
            return new int[]{ A[0]};
        var counters = new int[N];
        var maxCounter = 0;
        for (int k = 0; k < A.Length; k++)
        {
            for (int x = 1; x <= counters.Count(); x++)
            {
                if (A[k] == x && x <= A.Length)
                {
                    counters[x - 1]++;
                    maxCounter = Math.Max(counters[x - 1], maxCounter);
                }
                if (A[k] == N + 1)
                    counters[x-1] = maxCounter;
            }
        }
        return counters;
    }

    public static void Main()
    {
        var N = Convert.ToInt32(Console.ReadLine());
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(N, arr);
        foreach (var elem in result)
        {
            Console.WriteLine(elem);
        }
    }
}