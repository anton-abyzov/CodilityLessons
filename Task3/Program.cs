using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Xunit;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class Solution
{
    public int solution(int[] A, int D)
    {
        var N = A.Length;
        if (D >= N)
            return 0;

        //var coins = Enumerable.Range(1, D).ToArray();
        //var combinations = new int[A.Length+1];
        //combinations[0] = 1;
        //for (int coin = 1; coin <= coins.Length; coin++)
        //{
        //    for (int amount = 1; amount <= A.Length; amount++)
        //    {
        //        if (amount >= coin)
        //            combinations[amount] += combinations[amount - coin];
        //    }
        //}

        var timeStoneDict = new SortedDictionary<int, int>();
        for (int i = 0; i < A.Length; i++)
        {
            var time = A[i];
            timeStoneDict.Add(time, i);
        }

        var stones = new bool[N];
        for (int timeIndex = 0; timeIndex < timeStoneDict.Count; timeIndex++)
        {
            if (!timeStoneDict.ContainsKey(timeIndex)) continue;
            stones[timeStoneDict[timeIndex]] = true;
            if (CanCross(D, stones))
            {
                return timeIndex;
            }
        }

        return -1;
    }

    private bool CanCross(int D, bool[] stones)
    {
        var currentStone = -1;
        while (currentStone < stones.Length)
        {
            int step;
            for (step = 1; step <= D; step++)
            {
                if (step + currentStone >= stones.Length || stones[step + currentStone])
                {
                    currentStone = step + currentStone;
                    break;
                }
            }
            if (step > D)
                return false;
        }
        return true;
    }

    [Fact]
    public void BinarySearchTest()
    {
        // array should be sorted!!!!!
        var arr = new[] {1, -1, 0, 2, 3, 4};
        var findOne = Array.BinarySearch(arr, 1);
        Assert.NotEqual(1, findOne);
    }

    [Fact]
    public void Basic_test()
    {
        var A = new[] { 1, -1, 0, 2, 3, 5 };
        var D = 3;
        var result = solution(A, D);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Basic_not_passing()
    {
        var A = new[] { 1, -1, 0, 2, 3, 5 };
        var D = 1;
        var result = solution(A, D);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void Simple_passing_one_step()
    {
        var A = new[] { 1, 4, 0, 2, 3, 5 };
        var D = 1;
        var result = solution(A, D);
        Assert.Equal(5, result);
    }

    [Fact]
    public void D_greater_or_equal_N()
    {
        var result = solution(new[] { 1 }, 2);
        Assert.Equal(0, result);
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var D = Convert.ToInt32(Console.ReadLine());
        var result = new Solution().solution(arr, D);
        Console.WriteLine(result);
    }
}