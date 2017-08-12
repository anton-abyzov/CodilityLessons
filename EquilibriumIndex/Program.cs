using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public partial class Solution
{
    public int solution(int[] A)
    {
        long totalSum = A.Sum();
        long currentSum = 0;
        var results = new HashSet<int>();
        for (int i = 0; i < A.Length; i++)
        {
            var leftSum = currentSum;
            var rightSum = totalSum - currentSum - A[i];
            if (leftSum == rightSum)
                results.Add(i);
            currentSum += A[i];
        }
        if (results.Any())
            return results.First();
        return -1;
    }
}

   
