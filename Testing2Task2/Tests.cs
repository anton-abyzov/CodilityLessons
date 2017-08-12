using Xunit;


public partial class Solution
{
    [Fact]
    public void Basic()
    {
        var result = solution(1213);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Basic1()
    {
        var result = solution(12);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Basic2()
    {
        var result = solution(113);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Basic3()
    {
        var result = solution(311);
        Assert.Equal(3, result);
    }

    static void Main(string[] args)
    {
    }
}
