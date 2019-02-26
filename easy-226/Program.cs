using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace easy_226
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            else
            {
                int temp = 0;
                temp = root.left.val;
                root.left.val = root.right.val;
                root.right.val = temp;
            }
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
