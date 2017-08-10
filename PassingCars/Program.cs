using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        if (A.Length == 0)
            return -1;
        long totalSum = 0;
        
        long sumInTheArray = A.Sum(); 

        long collectedsum = 0;
        
        for (int i = 0; i < A.Length; i++)
        {
            collectedsum += A[i];
            if (A[i] == 0)
            {
                totalSum += (sumInTheArray - collectedsum);
            }
        }
        if (totalSum > 1000000000)
            return -1;
        
        return (int) totalSum;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr);
        Console.WriteLine(result);
    }
}