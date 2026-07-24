namespace DataStructure.Tree
{
    /*
    Time Complexity : O(n)
    Space Complexity: O(n)
    */
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
/*
Original Tree:

          1
       /     \
      2       3
    /  \     /  \
   4    5   6    7

Queue = [1]

--------------------------------------------------------
Iteration 1
--------------------------------------------------------
Dequeue = 1

Before Swap:
Left = 2
Right = 3

After Swap:
Left = 3
Right = 2

Tree becomes:

          1
       /     \
      3       2
    /  \     /  \
   6    7   4    5

Enqueue 3
Enqueue 2

Queue = [3, 2]

--------------------------------------------------------
Iteration 2
--------------------------------------------------------
Dequeue = 3

Before Swap:
Left = 6
Right = 7

After Swap:
Left = 7
Right = 6

Tree:

          1
       /     \
      3       2
    /  \     /  \
   7    6   4    5

Enqueue 7
Enqueue 6

Queue = [2, 7, 6]

--------------------------------------------------------
Iteration 3
--------------------------------------------------------
Dequeue = 2

Before Swap:
Left = 4
Right = 5

After Swap:
Left = 5
Right = 4

Tree:

          1
       /     \
      3       2
    /  \     /  \
   7    6   5    4

Enqueue 5
Enqueue 4

Queue = [7, 6, 5, 4]

--------------------------------------------------------
Iteration 4
--------------------------------------------------------
Dequeue = 7

Left = null
Right = null

Nothing to swap.

Queue = [6, 5, 4]

--------------------------------------------------------
Iteration 5
--------------------------------------------------------
Dequeue = 6

Left = null
Right = null

Nothing to swap.

Queue = [5, 4]

--------------------------------------------------------
Iteration 6
--------------------------------------------------------
Dequeue = 5

Left = null
Right = null

Nothing to swap.

Queue = [4]

--------------------------------------------------------
Iteration 7
--------------------------------------------------------
Dequeue = 4

Left = null
Right = null

Nothing to swap.

Queue = []

Queue becomes empty.
Algorithm terminates.

--------------------------------------------------------
Final Mirrored Tree

          1
       /     \
      3       2
    /  \     /  \
   7    6   5    4

--------------------------------------------------------
Inorder Traversal

Original Tree:
Left -> Root -> Right
4 2 5 1 6 3 7

Mirrored Tree:
7 3 6 1 5 2 4
*/