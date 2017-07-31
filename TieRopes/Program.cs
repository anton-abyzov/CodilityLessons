using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int K, int[] A)
    {
        if (A.Length == 0 || K == 0)
            return 0;
        var counter = 0;
        //var currentStreak = A[0];
        var currentStreak = 0;

        //if (currentStreak >= K)
        //{
        //    counter++;
        //    currentStreak = 0;
        //}

        for (int i = 0; i < A.Length; i++)
        {
            currentStreak += A[i];
            if (currentStreak >= K)
            {
                counter++;
                currentStreak = 0;
            }
        }

        //for (int i = 0; i < A.Length; i++)
        //{
        //    if (A[i] >= K)
        //    {
        //        counter++;
        //        currentStreak = 0;
        //        continue;
        //    }
        //    if (currentStreak < K)
        //    {
        //        currentStreak += A[i];
        //    }
        //}
        //if (currentStreak >= K)
        //    counter++;
        return counter;
    }

    public static void Main()
    {
        var k = Convert.ToInt32(Console.ReadLine());
        var a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(k, a);
        Console.WriteLine(result);
    }
}