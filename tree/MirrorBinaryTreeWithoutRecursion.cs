namespace DataStructure.tree
{
    public class MirrorBinaryTreeWithoutRecursion
    {
        public TreeNode MirrorTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            //Using a queue for level-order traversal
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode currentNode = queue.Dequeue();
                TreeNode temp = currentNode.left;
                currentNode.left = currentNode.right;
                currentNode.right = temp;

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }

            return root;
        }

        public void InOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrderTraversal(node.left);
            Console.Write(node.data + " ");
            InOrderTraversal(node.right);
        }

        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            MirrorBinaryTreeWithoutRecursion tree = new MirrorBinaryTreeWithoutRecursion();
            Console.WriteLine("Original tree (In-order traversal): ");
            tree.InOrderTraversal(root);

            tree.MirrorTree(root);
            Console.WriteLine("\nMirrored tree (In-order traversal): ");
            tree.InOrderTraversal(root);
        }

    }
}