namespace DataStructure.Tree
{
    public class BinarySearchTree
    {
        public static int COUNT = 0;
        public static Node SMALLEST_NODE;

        /*Find given element in BST, if element found return 1 else return 0.*/
        public static int FindNodeInBinaryTree(Node node, int element)
        {
            Node temp = node;
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
        public static void InsertNodeInBinarySearchTree(Node node, int element)
        {
            Node temp = node;
            Node parentNode = null; //Parent node for root node is null.
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
                node = new Node(element);
            }
            else if (parentNode.data < element)
            {
                parentNode.right = new Node(element);
            }
            else
            {
                parentNode.left = new Node(element);
            }

            //Traversing BST after node insertion
            InOrder(node);
        }

        public static void InOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.Write(root.data + " ");
            InOrder(root.right);
        }

        public static void Main(string[] args)
        {
            //Creating BST
            Node root = new Node(8);
            root.left = new Node(4);
            root.left.left = new Node(1);
            root.left.right = new Node(7);
            root.right = new Node(13);
            root.right.left = new Node(10);
            root.right.right = new Node(15);
            root.right.right.right = new Node(17);

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