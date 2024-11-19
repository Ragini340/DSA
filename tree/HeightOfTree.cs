using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.tree
{
    //Output:- Tree height is: 2
    public class HeightOfTree
    {
        public static int treeHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            int leftSubTreeHeight = treeHeight(root.left);
            int rightSubTreeHeight = treeHeight(root.right);
            return Math.Max(leftSubTreeHeight, rightSubTreeHeight) + 1;
        }

    }
}
