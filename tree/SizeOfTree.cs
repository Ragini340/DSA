namespace DataStructure.Tree
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
/*
   Consider the following tree:

            1
           / \
          2   3
         / \
        4   5

   Step 1:
   TreeSize(1)
   → Calls TreeSize(2)
   → Calls TreeSize(3)

   Step 2:
   TreeSize(2)
   → Calls TreeSize(4)
   → Calls TreeSize(5)

   Step 3:
   TreeSize(4)
   → Left = 0 (null)
   → Right = 0 (null)
   → Returns 1

   Step 4:
   TreeSize(5)
   → Left = 0 (null)
   → Right = 0 (null)
   → Returns 1

   Step 5:
   TreeSize(2)
   → Left = 1
   → Right = 1
   → Returns 1 + 1 + 1 = 3

   Step 6:
   TreeSize(3)
   → Left = 0 (null)
   → Right = 0 (null)
   → Returns 1

   Step 7:
   TreeSize(1)
   → Left = 3
   → Right = 1
   → Returns 3 + 1 + 1 = 5

   Final Output:
   Tree size is: 5
*/