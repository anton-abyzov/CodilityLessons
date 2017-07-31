using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public static int[] solution(int[] A, int K)
    {
        if (A.Length == 0)
            return new int[0];
        var length = A.Length;
        if (K % length == 0)
            return A;
        K = K % length;
        var result = new int[length];
        Array.Copy(A, length - K, result, 0, K);
        Array.Copy(A, 0, result, K, length - K);
        //for (int i = 0; i < length; i++)
        //{
        //    var temp = A[i];
        //    A[i]
        //}
        return result;
    }

    public static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var K = Convert.ToInt32(Console.ReadLine());
        var array = Array.ConvertAll(line, int.Parse);
        var res = solution(array, K);
        foreach (var elem in res)
        {
            Console.Write(elem + " ");
        }
    }
}