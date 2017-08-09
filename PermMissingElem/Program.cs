using System;
using System.Collections.Generic;
using System.Linq;


class Solution
{
    static void Main(string[] args)
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr);
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
}
