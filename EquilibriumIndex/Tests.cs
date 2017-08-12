using System.Collections.Generic;
using Xunit;

public partial class Solution
{
    [Fact]
    public void Basic_case()
    {
        var A = new int[] {-1, 3, -4, 5, 1, -6, 2, 1};
        var result = solution(A);
        Assert.True(new HashSet<int>(){ 1, 3, 7}.Contains(result));
    }

    public static void Main()
    {

    }

}