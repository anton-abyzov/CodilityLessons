using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace _21July2019Test
{
    public class Solution
    {
        [Theory]
        [InlineData("2 4 1 6 5 9 7", 3)]
        public void Test3(String arrayStr, int expectedResult)
        {
            var array = Array.ConvertAll(arrayStr.Split(' '), int.Parse);
            var result = this.solution3(array);
            Assert.Equal(expectedResult, result);
        }

        public int solution3(int[] A)
        {
            var min = A[0];
            var max = A[0];
            var counter = 0;
            for (var i = 1; i < A.Length; i++)
            {               
                min = Math.Min(A[i], min);
                max = Math.Max(A[i], max);

                if (A[i] > A[i - 1] && A[i] > max)
                {
                    counter++;
                }
            }
            return counter;
        }


        public int solution1(Point2D[] A)
        {
            var statues = new HashSet<Point2D>(A);
            var shotsCount = 0;
            while (statues.Any())
            {
                var statueOnTarget = statues.First();
                statues.Remove(statueOnTarget);
                statues.RemoveWhere(stat => sameSign(stat.x, statueOnTarget.x) && sameSign(stat.y, statueOnTarget.y) && (stat.x / statueOnTarget.x) == (stat.y / statueOnTarget.y));
                shotsCount++;
            }
            return shotsCount;           
        }
        public bool sameSign(int num1, int num2)
        {
            if (num1 > 0 && num2 < 0)
                return false;
            if (num1 < 0 && num2 > 0)
                return false;
            return true;
        }

        [Fact]
        public void Test1_Default()
        {
            var array = new Point2D[]
            {
                new Point2D{x=-1, y=-2},
                new Point2D{x=1, y=2},
                new Point2D{x=2, y=4},
                new Point2D{x=-3, y=2},
                new Point2D{x=2, y=-2},
            };
            var result = solution1(array);
            Assert.Equal(4, result);
        }


    }

    public class Point2D
    {
        public int x;
        public int y;
    };
}
