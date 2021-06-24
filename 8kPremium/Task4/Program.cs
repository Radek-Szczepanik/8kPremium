using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode();
            tree.DeepestLeavesSum(tree);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public int DeepestLeavesSum(TreeNode root)
        {
            int sum = 0;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                int count = q.Count;
                sum = 0;
                for (int i = 0; i < count; i++)
                {
                    var node = q.Dequeue();
                    sum += node.val;
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
            }
            return sum;
        }
    }
}
