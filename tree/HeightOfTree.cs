namespace DataStructure.Tree
{
    /*
    Time Complexity: O(n), where n is the number of nodes in the binary tree as each node is visited once.
    Space Complexity: O(h), where h is height of the binary tree.*/
    //Output:- Tree height is: 2
    /*
     The height of a binary tree is the length of the longest path from the root node to a leaf node. The height of an empty tree is -1,
     and the height of a tree with only one node is 0.
    */
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