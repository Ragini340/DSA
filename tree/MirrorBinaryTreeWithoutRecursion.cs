namespace DataStructure.Tree
{
    public class MirrorBinaryTreeWithoutRecursion
    {
        public Node MirrorTree(Node root)
        {
            if (root == null)
            {
                return null;
            }

            //Using a queue for level-order traversal
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node currentNode = queue.Dequeue();
                Node temp = currentNode.left;
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

        public void InOrderTraversal(Node node)
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
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);

            MirrorBinaryTreeWithoutRecursion tree = new MirrorBinaryTreeWithoutRecursion();
            Console.WriteLine("Original tree (In-order traversal): ");
            tree.InOrderTraversal(root);

            tree.MirrorTree(root);
            Console.WriteLine("\nMirrored tree (In-order traversal): ");
            tree.InOrderTraversal(root);
        }

    }
}