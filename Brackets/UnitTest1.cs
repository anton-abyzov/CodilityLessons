using System;
using Xunit;

namespace Brackets
{
    public class Solution
    {
        [Theory]
        [InlineData("{[()()]}", 1)]
        [InlineData("([)()]", 0)]
        public void BracketsTests(string input, int expectedResult)
        {
            var result = solution(input);
            Assert.Equal(expectedResult, result);
        }

        public int solution(string S)
        {
            //for (var i =)
            return 1;

        }
    }
}
