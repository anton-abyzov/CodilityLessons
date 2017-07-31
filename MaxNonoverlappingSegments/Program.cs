using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public  int solution(int[] A, int[] B)
    {
        // write your code in Java SE 8

        if (A.Length == 0 || B.Length == 0) return 0;
        int count = 1;
        int lastIndex = 0;

        for (int i = 1; i < B.Length; i++)
        {
            if (A[i] <= B[lastIndex]) continue;
            lastIndex = i;
            count++;
        }
        return count;
    }

    public static void Main()
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var a = new int[n];
        var b = new int[n];
        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(' ');
            a[i] = Convert.ToInt32(line[0]);
            b[i] = Convert.ToInt32(line[1]);
        }
        var result = new Solution().solution(a, b);
        Console.WriteLine(result);
    }
}