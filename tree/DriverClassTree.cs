namespace DataStructure.tree
{
    public class DriverClassTree
    {
        public static void Main(string[] args)
        {
            //BinaryTreeTraversal
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(4);
            root.left.right = new Node(3);
            root.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            Console.WriteLine("BinaryTreeTraversal:-");
            Console.WriteLine("Preorder traversal:");
            BinaryTreeTraversals.Preorder(root);
            Console.WriteLine("Inorder traversal:");
            BinaryTreeTraversals.Inorder(root);
            Console.WriteLine("Postorder traversal:");
            BinaryTreeTraversals.Postorder(root);
            Console.WriteLine();

            //Mirror Tree
            root = new Node(5);
            root.left = new Node(3);
            root.right = new Node(6);
            root.left.left = new Node(2);
            root.left.right = new Node(4);
            MirrorTree.InorderTraversal(root);
            Console.WriteLine();
            Console.WriteLine("Mirror tree using inorder traversal:-");
            Node mirrorImageTree = MirrorTree.MirrorTrees(root);
            MirrorTree.InorderTraversal(mirrorImageTree);
            Console.WriteLine();

            //SizeOfTree
            int treeSize = SizeOfTree.TreeSize(root);
            Console.WriteLine("Tree size is: " + treeSize);
            Console.WriteLine();

            //HeightOfTree
            int treeHeight = HeightOfTree.TreeHeight(root);
            Console.WriteLine("Tree height is: " + treeHeight);
            Console.WriteLine();

        }
    }
}
