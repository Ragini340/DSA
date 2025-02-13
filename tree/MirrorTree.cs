namespace DataStructure.tree
{
    /*Time complexity: O(N),where N is the number of nodes in given binary tree.
    Auxiliary Space: O(h), where h is the height of the tree.*/
    public class MirrorTree
    {
        public static Node MirrorTrees(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Node leftNode = MirrorTrees(root.left);
            Node rightNode = MirrorTrees(root.right);
            root.left = rightNode;
            root.right = leftNode;
            return root;
        }

        public static void InorderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversal(root.left);
            Console.WriteLine(root.data + " ");
            InorderTraversal(root.right);
        }

    }
}
