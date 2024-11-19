using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.tree
{
    /*
    Time Complexity: O(n), where n is the number of nodes in the binary tree as each node is visited once.
    Auxiliary Space: O(h), where h is height of the binary tree.*/
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
