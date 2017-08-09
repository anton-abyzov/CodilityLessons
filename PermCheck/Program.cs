using System;
using System.Collections.Generic;

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
        var result = new Solution().solution(arr);
        Console.WriteLine(result);
    }
}