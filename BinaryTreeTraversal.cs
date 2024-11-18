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
        public static void Preorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data + " ");
            Preorder(root.left);
            Preorder(root.right);
        }

        public static void Inorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Inorder(root.left);
            Console.WriteLine(root.data + " ");
            Inorder(root.right);
        }

        public static void Postorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Postorder(root.left);
            Postorder(root.right);
            Console.WriteLine(root.data + " ");
        }

        public static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(4);
            root.left.right = new Node(3);
            root.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            Console.WriteLine("Preorder traversal:");
            Preorder(root);
            Console.WriteLine("Inorder traversal:");
            Inorder(root);
            Console.WriteLine("Postorder traversal:");
            Postorder(root);
        }

    }
}
