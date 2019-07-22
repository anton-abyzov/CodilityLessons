using System;
using System.Collections.Generic;
using System.Linq;


class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(0 ^ 5);
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solutionXor(arr);
        Console.WriteLine(result);
    }

    public int solution(int[] A)
    {
        if (A.Length == 0)
            return 1;

        var visited = new HashSet<int>();
        var optimal = new HashSet<int>();
        for (int i = 1; i <= A.Length + 1; i++)
        {
            optimal.Add(i);
        }
        for (int i = 0; i < A.Length; i++)
        {
            visited.Add(A[i]);
        }
        optimal.ExceptWith(visited);
        return optimal.First();
    }

    public int solutionXor(int[] A)
    {
        var result = 0;
        for (var i = 0; i < A.Length; i++)
        {
            result ^= A[i] ^ (i + 1);
        }
        return result^(A.Length + 1);
    }
}
