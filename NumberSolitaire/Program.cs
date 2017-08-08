using System;

namespace NumberSolitaire
{
    class Program
    {
        static void Main(string[] args)
        {
            var startPos = 0;
            var line = Console.ReadLine().Split(' ');
            var a = Array.ConvertAll(line, int.Parse);
            var solution = new Program().solution(a);
            Console.WriteLine(solution);
        }

        //public int solution(int[] A)
        //{
        //    var startPos = 0;
        //    var sum = A[0];
        //    var i = 0;
        //    while(i<A.Length)
        //    {
        //        var maxMove = int.MinValue;
        //        int j;
        //        var indexOfMaxMove = 0;
        //        for (j = 1; j <= 6; j++)
        //        {
        //            if (i + j >= A.Length) continue;
        //            if (A[i + j] > maxMove)
        //            {
        //                maxMove = A[i + j];
        //                indexOfMaxMove = j;
        //            }
        //        }
        //        sum += maxMove;
        //        i += indexOfMaxMove;
        //    }
        //    return sum;
        //}

        public int solution(int[] a)
        {
            var maxInt = new int[a.Length];
            maxInt[0] = a[0];
            maxInt[1] = a[0] + a[1];

            for (int i = 2; i < a.Length; i++)
            {
                int max = Int32.MinValue;
                for (int j = 1; j <= 6; j++)
                {
                    if (i - j >= 0)
                    {
                        max = Math.Max(max, maxInt[i - j] + a[i]);
                    }
                }
                maxInt[i] = max;
            }
            return maxInt[a.Length - 1];
        }
    }
}