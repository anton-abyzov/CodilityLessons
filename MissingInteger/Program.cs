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
        if (A.Length < 0)
            return -1;
        var set = new HashSet<int>(A);
        for (int i = 1; i < 100002; i++)
        {
            if (!set.Contains(i))
                return i;
        }
        return -1;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr);
        Console.WriteLine(result);
    }
}