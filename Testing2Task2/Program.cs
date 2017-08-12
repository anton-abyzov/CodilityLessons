using System;
using System.Collections.Generic;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public partial class Solution
{
    public int solution(int N)
    {
        var str = N.ToString().ToCharArray().Select(x => x.ToString()).ToArray();
        var arr = Array.ConvertAll(str, int.Parse);

        var unique = new HashSet<int>();
        for (int z = 0; z < arr.Length; z++)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    var valueStr = string.Join("", arr);
                    var intValue = int.Parse(valueStr);
                    if (intValue.ToString().Length != arr.Length) continue;
                    unique.Add(intValue);
                    if (j + 1 < arr.Length)
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        return unique.Count;
    }

    //public int CountCombinations(int n, int m)
    //{

    //}
}