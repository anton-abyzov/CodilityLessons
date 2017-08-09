using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int X, int[] A)
    {
        var set = new HashSet<int>(Enumerable.Range(1, X));
        for (int i = 0; i < A.Length; i++)
        {
            if (set.Contains(A[i]))
                set.Remove(A[i]);
            if (!set.Any())
                return i;
        }
        return -1;
    }

    public static void Main()
    {
        var X = Convert.ToInt32(Console.ReadLine());
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(X, arr);
        Console.WriteLine(result);
    }
}