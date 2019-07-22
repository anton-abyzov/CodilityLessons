using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        var set = new HashSet<int>(A);
        if (A.Length != set.Count)
            return 0;
        for (int i = 1; i <= A.Length; i++)
        {
            if (!set.Contains(i))
                return 0;
        }
        return 1;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solutionXor(arr);
        Console.WriteLine(result);
    }

    public int solutionXor(int[] A)
    {
        var check = Enumerable.Range(1, A.Length).ToArray();
        int result = 0;
        for (int i = 0; i < A.Length; i++)
        {
            result ^= check[i] ^ A[i];
        }
        return result == 0 ? 1 : 0;
    }
}
