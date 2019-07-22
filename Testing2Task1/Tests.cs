using Xunit;


public partial class Solution
{

    [Fact]
    public void Basic()
    {
        var tree = new Tree(4);
        var tree5 = new Tree(5);
        var tree4_2 = new Tree(4);
        var tree5_1 = new Tree(5);
        var tree5_2 = new Tree(5);
        var tree6_1 = new Tree(6);
        var tree6_2 = new Tree(6);
        var tree1 = new Tree(1);
        tree.l = tree5;
        tree.r = tree6_1;
        tree5_1.l = tree4_2;
        tree4_2.l = tree5_2;
        tree6_1.l = tree1;
        tree6_1.r = tree6_2;
        var result = solution(tree);
        Assert.Equal(3, result);
    }

    
}
