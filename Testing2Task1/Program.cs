using System;
using System.Collections.Generic;
using System.Security.Policy;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public partial class Solution
{
    public int solution(Tree T)
    {
        if (T == null)
            return 0;
        var result = Traverse(T, new HashSet<int>());
        return result;
    }

    public int Traverse(Tree T, HashSet<int> distinct)
    {
        if (T == null)
            return distinct.Count;
        distinct.Add(T.x);
        var leftMax = Traverse(T.l, new HashSet<int>(distinct));
        var rightMax = Traverse(T.r, new HashSet<int>(distinct));
        var max = Math.Max(leftMax, rightMax);
        return max;
    }

    public class Tree
    {
        public Tree(int value)
        {
            x = value;
        }
        public int x;
        public Tree l;
        public Tree r;
    }
}