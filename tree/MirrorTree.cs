using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.tree
{
    /*Time complexity: O(N),where N is the number of nodes in given binary tree.
    Auxiliary Space: O(h), where h is the height of the tree.*/
    public class MirrorTree
    {
        public static Node mirrorTree(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Node leftNode = mirrorTree(root.left);
            Node rightNode = mirrorTree(root.right);
            root.left = rightNode;
            root.right = leftNode;
            return root;
        }

        public static void inorderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            inorderTraversal(root.left);
            Console.WriteLine(root.data + " ");
            inorderTraversal(root.right);
        }

    }
}
