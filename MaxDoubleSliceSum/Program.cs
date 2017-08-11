using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        var N = A.Length - 2;

        var leftSums = new int[N];
        var rightSums = new int[N];

        for (int i = 0, length = N - 1; i < length; i++)
        {
            leftSums[i + 1] = Math.Max(0, leftSums[i] + A[i + 1]);
            rightSums[length - i - 1] = Math.Max(0, rightSums[length - i] + A[length - i + 1]);
        }

        var maxSum = int.MinValue;

        for (int i = 0; i < N; i++)
        {
            maxSum = Math.Max(maxSum, leftSums[i] + rightSums[i]);
        }

        return maxSum;
    }
}

