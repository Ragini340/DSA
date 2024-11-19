using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.tree
{
    public class Node
    {
        public int data;
        public Node left = null;
        public Node right = null;

        public Node(int data)
        {
            this.data = data;
        }
    }

    /*Time Complexity: O(N)
    Auxiliary Space: If we do not consider the size of the stack for function calls then O(1) otherwise O(h) where h is the height of the tree.*/
    public class BinaryTreeTraversals
    {
        public static void preorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data + " ");
            preorder(root.left);
            preorder(root.right);
        }

        public static void inorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left);
            Console.WriteLine(root.data + " ");
            inorder(root.right);
        }

        public static void postorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            postorder(root.left);
            postorder(root.right);
            Console.WriteLine(root.data + " ");
        }

    }
}
