namespace DataStructure.tree
{
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    public class BinarySearchTree
    {
        bool isBSTree;
        TreeNode prev = null;
        TreeNode current = null;
        public static int COUNT = 0;
        public static TreeNode SMALLEST_NODE;

        /*Find given element in BST, if element found return 1 else return 0.*/
        public static int FindNodeInBinaryTree(TreeNode node, int element)
        {
            TreeNode temp = node;
            while (temp != null)
            {
                if (temp.data == element)
                {
                    return 1;
                }
                else if (temp.data < element)
                {
                    temp = temp.right;
                }
                else
                {
                    temp = temp.left;
                }
            }
            return 0;
        }

        //Insert node in BST
        public static void InsertNodeInBinarySearchTree(TreeNode node, int element)
        {
            TreeNode temp = node;
            TreeNode parentNode = null; //Parent node for root node is null.
            while (temp != null)
            {
                parentNode = temp;
                if (temp.data == element)  //If node already exists in given BST
                {
                    return;
                }
                else if (temp.data < element)
                {
                    temp = temp.right;
                }
                else
                {
                    temp = temp.left;
                }
            }
            if (parentNode == null)  //If given tree is null, it will create tree with single node
            {
                node = new TreeNode(element);
            }
            else if (parentNode.data < element)
            {
                parentNode.right = new TreeNode(element);
            }
            else
            {
                parentNode.left = new TreeNode(element);
            }

            //Traversing BST after node insertion
            InOrder(node);
        }

        public static void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.WriteLine("\t" + root.data);
            InOrder(root.right);
        }

        public static void Main(string[] args)
        {
            //Creating BST
            TreeNode root = new TreeNode(8);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(7);
            root.right = new TreeNode(13);
            root.right.left = new TreeNode(10);
            root.right.right = new TreeNode(15);
            root.right.right.right = new TreeNode(17);

            //Finding node in BST
            int elementFound = FindNodeInBinaryTree(node: root, element: 13);
            if (elementFound == 1)
            {
                Console.WriteLine("Given element is found in Binary Search Tree");
            }
            else
            {
                Console.WriteLine("Given element is not found in Binary Search Tree");
            }

            //Insering node in BST
            InsertNodeInBinarySearchTree(node: root, element: 14);
        }

    }
}
