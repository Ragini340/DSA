using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
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

    public class BinaryTreeTraversal
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
