namespace DataStructure.Tree
{
    /*
    Time Complexity: O(n), where n is the number of nodes in the binary tree as each node is visited once.
    Auxiliary Space: O(h), where h is height of the binary tree.*/
    //Output:- Tree height is: 2
    public class HeightOfTree
    {
        public static int TreeHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            int leftSubTreeHeight = TreeHeight(root.left);
            int rightSubTreeHeight = TreeHeight(root.right);
            return Math.Max(leftSubTreeHeight, rightSubTreeHeight) + 1;
        }

    }
}
