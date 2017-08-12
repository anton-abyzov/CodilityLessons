using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public partial class Solution
{
    public int solution(string S)
    {
        if (S.Length == 1)
            return 1;
        if (S[0] != S[S.Length - 1])
            return 0;

        string prefix = "";
        string suffix = "";
        var prefixes = new HashSet<string>();
        var suffixes = new HashSet<string>();

        for (int i = 0; i < S.Length; i++)
        {
            prefix += S[i];
            suffix =  S[S.Length - 1 - i] + suffix;
            if (prefix.Length < S.Length)
            {
                prefixes.Add(prefix);
                suffixes.Add(suffix);
            }
        }

        prefixes.IntersectWith(suffixes);
        var lengths = prefixes.Select(x => x.Length);
        return lengths.Max();
    }
}