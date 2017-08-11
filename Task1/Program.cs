using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public bool solution(int[] A)
    {

        //Array.Sort(A, new Comparison<int>((x, y) =>
        //{
        //    if (y - x > 0)
        //        counter++;
        //    if (counter > 1)

        //    return x.CompareTo(y);

        //}) );
        //return counter;
        var N = A.Length;
        var previousHigher = A[0];
        var isSwapMode = false;
        var counter = 0;
        for (int i = 1; i < A.Length; i++)
        {
            if (isSwapMode)
            {
                if (A[i] == A[i-1])
                    continue;

                if (A[i] < previousHigher)
                    return false;
                    
                isSwapMode = false;
                counter++;
                if (counter > 1)
                    return false;

            }
            if (A[i] < previousHigher)
            {
                isSwapMode = true;
            }
            else
            {
                previousHigher = A[i];
            }
        }
        return true;
    }

    public static void Main()
    {
        var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        var result = new Solution().solution(arr);
        Console.WriteLine(result);
    }
}