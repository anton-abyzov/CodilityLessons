using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A, int D)
    {
        var N = A.Length;
        if (D >= N)
            return 0;

        //for (int i = 0; i < N; i++)
        //{
        //    var nextStone = Array.BinarySearch(A, 0);

        //}
        var counter = D - 1;
        bool[] stones = new bool[N + 1];
        for (int i = 0; i < A.Length; i++)
        {
            var nextStone = Array.BinarySearch(A, i);
            if (nextStone < 0)
                continue;
            if (!stones[nextStone])
            {
                stones[nextStone] = true;
                counter--;
            }
            if (counter == 0) return i;
        }


        return -1;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var D = Convert.ToInt32(Console.ReadLine());
        var result = new Solution().solution(arr, D);
        Console.WriteLine(result);
    }
}