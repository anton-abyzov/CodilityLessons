using System;
using System.Collections.Generic;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A, int[] B)
    {
        var index = 0;
        var isEatingMode = false;
        var eatingIndex = -1;
        var counter = 0;
        while (index < B.Length)
        {
            if (B[index] == 1)
            {
                if (isEatingMode)
                {
                    eatingIndex = index;
                }
                else
                {
                    isEatingMode = true;
                    eatingIndex = index;
                }
                counter++;
            }
            if (B[index] == 0)
            {
                if (isEatingMode)
                {
                    if (A[index] > A[eatingIndex])
                    {
                        isEatingMode = false;
                    }
                }
                else
                {
                    counter++;
                }
            }
            index++;
        }
        return counter;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var arr2= Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr, arr2);
        Console.WriteLine(result);
    }
}