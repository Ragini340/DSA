namespace DataStructure.tree
{
    public class SizeOfTree
    {
        /*Time Complexity: O(n), where n is the number of nodes in binary tree.
        Auxiliary Space: O(h), where h is the height of the tree.*/
        //Output:- Tree size is: 5
        public static int TreeSize(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int l = TreeSize(root.left);
            int r = TreeSize(root.right);
            return l + r + 1;
        }

    }
}
