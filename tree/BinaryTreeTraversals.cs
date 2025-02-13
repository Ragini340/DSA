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

    }
}
