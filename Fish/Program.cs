using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A, int[] B)
    {
        var stack = new Stack<int>();
        var counterOfOne = 0;
        for (int i = A.Length - 1; i >= 0; i--)
        {
            if (B[i] == 0)
                stack.Push(A[i]);
            if (B[i] == 1)
            {
                if (!stack.Any())
                    counterOfOne++;
                while (stack.Any() && stack.Peek() < A[i])
                {
                    stack.Pop();
                }
            }
        }
        return stack.Count + counterOfOne;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var arr2= Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr, arr2);
        Console.WriteLine(result);
    }
}