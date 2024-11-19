using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.tree
{
    public class SizeOfTree
    {
        /*Time Complexity: O(n), where n is the number of nodes in binary tree.
        Auxiliary Space: O(h), where h is the height of the tree.*/
        //Output:- Tree size is: 5
        public static int treeSize(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int l = treeSize(root.left);
            int r = treeSize(root.right);
            return l + r + 1;
        }

    }
}
