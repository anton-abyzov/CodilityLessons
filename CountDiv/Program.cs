using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int A, int B, int K)
    {
        var counter = 0;
        var index = A;
        //while(index <=B)
        //{
        //    if (index % K == 0)
        //    {
        //        counter++;
        //        index += K;
        //    }
        //    else
        //    {
        //        index++;
        //    }
        //}
        //Console.WriteLine(counter);
        counter = 0;
        var diff = B - A;
      
        counter = B / K - A / K + (A % K == 0 ? 1 : 0);
        return counter;
    }

    public static void Main()
    {
        var A = Convert.ToInt32(Console.ReadLine());
        var B = Convert.ToInt32(Console.ReadLine());
        var K = Convert.ToInt32(Console.ReadLine());
        var result = new Solution().solution(A,B,K);
        Console.WriteLine(result);
    }
}