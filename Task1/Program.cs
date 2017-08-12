using System;
using System.Linq;
using Xunit;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

    

public class Solution
{
    public bool solution(int[] A)
    {
        var lastElemIndex = 0;
        var counter = 0;
        var index = 1;
        while(index < A.Length)
        {
            if (A[index] < A[lastElemIndex])
            {
                while (index + 1 < A.Length && A[index + 1] == A[index])
                {
                    index++;
                }

                var temp = A[lastElemIndex];
                A[lastElemIndex] = A[index];
                A[index] = temp;

                counter++;
                lastElemIndex = index;
                index++;

            }
            else
            {
                index++;
                lastElemIndex++;
            }
            if (counter > 1)
                return false;
        }
        return true;
    }
    
    [Fact]
    public void Large_array_true()
    {
        var arr = Enumerable.Range(1, 100000).ToArray();
        arr[3] = 1;
        var result = solution(arr);
        Assert.True(result);
    }

    [Fact]
    public void Loose_edge_array_true()
    {
        var result = solution(new []{5, 3, 5, 6, 7});
        Assert.True(result);
    }

    [Fact]
    public void Repeating_end_true()
    {
        var result = solution(new []{5, 3, 3, 3, 3, 3, 3, 3, 3});
        Assert.True(result);
    }

    [Fact]
    public void Repeating_not_end_true()
    {
        var result = solution(new []{5, 3, 3, 3, 6});
        Assert.True(result);
    }

    [Fact]
    public void Extra_small_array_true()
    {
        var result = solution(new[] {1});
        Assert.True(result);
    }

    [Fact]
    public void Small_array_true()
    {
        var result = solution(new[]{2, 1});
        Assert.True(result);
    }

    [Fact]
    public void Small_array_false()
    {
        var result = solution(new[] { 3, 1, 2 });
        Assert.False(result);
    }

    [Fact]
    public void MaxIntTest()
    {
        var arr = Enumerable.Range(1, 100000).ToArray();
        for (int i = 0; i < 100000; i++)
        {
            arr[i] = int.MaxValue;
        }

        arr[3] = 1;
        arr[4] = 2;
        Assert.False(solution(arr));
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr);
        Console.WriteLine(result);
    }
}