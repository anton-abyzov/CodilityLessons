using Xunit;


public partial class Solution
{
    [Fact]
    public void Basic()
    {
        var input = "abbabba";
        var result = solution(input);
        Assert.Equal(4, result);
    }

    [Fact]
    public void None()
    {
        var input = "codility";
        var result = solution(input);
        Assert.Equal(0, result);
    }

    static void Main(string[] args)
    {
    }
}
