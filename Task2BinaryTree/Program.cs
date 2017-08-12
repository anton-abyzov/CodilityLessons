using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Task2BinaryTree
{
    public class Solution
    {
        public static void Main()
        {
            
        }

        private static Tree _tree;
        public Solution()
        {
            var tree5 = new Tree(5);
            var tree3 = new Tree(3);
            var tree10 = new Tree(10);
            tree5.left = tree3;
            tree5.right = tree10;
            var tree20 = new Tree(20);
            var tree6 = new Tree(6);
            tree3.left = tree20;
            tree20.left = tree6;
            var tree1 = new Tree(1);
            var tree15 = new Tree(15);
            var tree30 = new Tree(30);
            var tree9 = new Tree(9);
            var tree8 = new Tree(8);
            tree10.left = tree1;
            tree10.right = tree15;
            tree15.left = tree30;
            tree15.right = tree8;
            tree30.right = tree9;
            _tree = tree5;
        }

        public int solution(Tree T)
        {
            if (T == null)
                return 0;

            return Traverse(T, 0, 0, "left");
        }
        
        public int Traverse(Tree T, int counter, int level, string direction)
        {
            if (T == null)
            {
                return counter;
            }

            var counterLeft = (direction == "right" && level != 0 && T.left != null) ? counter + 1: counter;
            var countOnLeftPath =  Traverse(T.left, counterLeft, level + 1, "left");
            
            var counterRight = (direction == "left" && level != 0 && T.right != null) ? counter + 1 : counter;
            var countOnRightPath = Traverse(T.right, counterRight, level + 1, "right");

            var result = Math.Max(countOnRightPath, countOnLeftPath);
            return result;
        }

        [Fact]
        public void Basic_case()
        {
            var result = solution(_tree);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Basic_plus_one()
        {
            var tree5 = new Tree(5);
            var tree3 = new Tree(3);
            var tree10 = new Tree(10);
            tree5.left = tree3;
            tree5.right = tree10;
            var tree20 = new Tree(20);
            var tree6 = new Tree(6);
            tree3.left = tree20;
            tree20.left = tree6;
            var tree1 = new Tree(1);
            var tree15 = new Tree(15);
            var tree30 = new Tree(30);
            var tree9 = new Tree(9);
            var tree7 = new Tree(7);
            var tree8 = new Tree(8);
            tree10.left = tree1;
            tree10.right = tree15;
            tree15.left = tree30;
            tree15.right = tree8;
            tree30.right = tree9;
            tree9.left = tree7;
            _tree = tree5;
            var result = solution(_tree);
            Assert.Equal(3, result);
        }
    }

    public class Tree
    {
        public Tree(int value)
        {
            x = value;
        }
        public int x;
        public Tree left;
        public Tree right;
    }
}
