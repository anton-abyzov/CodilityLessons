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
            return new int[] { A[0] };
        var counters = new int[N];
        var maxCounter = 0;
        var isLatestOperationMaxCounter = false;
        for (int k = 0; k < A.Length; k++)
        {
            if (A[k] > N + 1) continue;

            if (A[k] <= N)
            {
                counters[A[k] - 1]++;
                maxCounter = Math.Max(counters[A[k] - 1], maxCounter);
                isLatestOperationMaxCounter = false;
            }

            if (A[k] == N + 1)
            {
                if (!isLatestOperationMaxCounter)
                {
                    for (int i = 0; i < counters.Length; i++)
                    {
                        counters[i] = maxCounter;
                    }
                    isLatestOperationMaxCounter = true;
                }
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