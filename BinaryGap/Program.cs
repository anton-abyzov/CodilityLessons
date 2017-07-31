using System;
using System.CodeDom;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N)
    {
        var binaryStr = Convert.ToString(N, 2);
        var maxLength = 0;
        var currentStreak = 0;
        for (int i = 0; i < binaryStr.Length; i++)
        {
            //ending
            if (binaryStr[i] == '1' && currentStreak > 0)
            {
                maxLength = Math.Max(maxLength, currentStreak);
                currentStreak = 0;
            }
            //in middle
            if (binaryStr[i] == '0')
                currentStreak++;
        }
        return maxLength;
    }

    public static void Main()
    {
        var num = Convert.ToInt32(Console.ReadLine());
        var result = new Solution().solution(num);
        Console.WriteLine(result);
    }
}