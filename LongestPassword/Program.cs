using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(string S)
    {
        if (S.Length == 0)
            return -1;
        var words = S.Split(' ');
        var longestPass = -1;
        foreach (var word in words)
        {
            if (IsValidPassword(word))
            {
                longestPass = Math.Max(longestPass, word.Length);
            }
        }
        return longestPass;
    }

    private bool IsValidPassword(string word)
    {
        var charCount = 0;
        var digitCount = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (!Char.IsDigit(word[i]) && !((word[i] >= 'A' && word[i] <= 'Z') || (word[i] >= 'a' && word[i] <= 'z')))
                return false;
            if ((word[i] >= 'A' && word[i] <= 'Z') || (word[i] >= 'a' && word[i] <= 'z'))
                charCount++;
            if (char.IsDigit(word[i]))
                digitCount++;
        }
        return charCount % 2 == 0 && digitCount % 2 != 0;
    }

    public static void Main()
    {
        var str = Console.ReadLine();
        Console.WriteLine(new Solution().solution(str));
    }
}