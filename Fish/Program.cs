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
        var upstream = new Stack<int>();
        var downstream = new Stack<int>();
        for (int i = 0; i < A.Length; i++)
        {
            if (B[i] == 0)
            {
                upstream.Push(A[i]);
                if (downstream.Any())
                {
                    while (downstream.Any() && A[i] > downstream.Peek())
                    {
                        downstream.Pop();
                    }
                    if (downstream.Any())
                        upstream.Pop();
                }
            }
            if (B[i] == 1)
            {
                downstream.Push(A[i]);
            }
        }
        return downstream.Count + upstream.Count;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr, arr2);
        Console.WriteLine(result);
    }
}