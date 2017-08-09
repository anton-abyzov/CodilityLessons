using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int X, int Y, int D)
    {
        if (Y <= X)
            return 0;
        decimal diff = Y - X;
        var divide = (diff / D);
        var steps = Math.Ceiling(divide);
        return (int) steps;
    }

    public static void Main()
    {
        var X = Convert.ToInt32(Console.ReadLine());
        var Y = Convert.ToInt32(Console.ReadLine());
        var D = Convert.ToInt32(Console.ReadLine());
        var result = new Solution().solution(X, Y, D);
        Console.WriteLine(result);
    }
}