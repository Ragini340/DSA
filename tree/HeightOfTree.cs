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
/*
        1
       / \
      2   3
     /
    4

Expected Output:
Tree height is: 2

Call:
TreeHeight(1)

Step 1:
root = 1
leftSubTreeHeight = TreeHeight(2)

---------------------------------------------------------

TreeHeight(2)

root = 2
leftSubTreeHeight = TreeHeight(4)

---------------------------------------------------------

TreeHeight(4)

root = 4

leftSubTreeHeight = TreeHeight(null)
= -1

rightSubTreeHeight = TreeHeight(null)
= -1

Return:
Math.Max(-1, -1) + 1
= -1 + 1
= 0

TreeHeight(4) returns 0

---------------------------------------------------------

Back to TreeHeight(2)

leftSubTreeHeight = 0

rightSubTreeHeight = TreeHeight(null)
= -1

Return:
Math.Max(0, -1) + 1
= 0 + 1
= 1

TreeHeight(2) returns 1

---------------------------------------------------------

Back to TreeHeight(1)

leftSubTreeHeight = 1

rightSubTreeHeight = TreeHeight(3)

---------------------------------------------------------

TreeHeight(3)

root = 3

leftSubTreeHeight = TreeHeight(null)
= -1

rightSubTreeHeight = TreeHeight(null)
= -1

Return:
Math.Max(-1, -1) + 1
= -1 + 1
= 0

TreeHeight(3) returns 0

---------------------------------------------------------

Back to TreeHeight(1)

leftSubTreeHeight = 1
rightSubTreeHeight = 0

Return:
Math.Max(1, 0) + 1
= 1 + 1
= 2

TreeHeight(1) returns 2

---------------------------------------------------------
Call Stack Summary
---------------------------------------------------------

TreeHeight(4)
= Max(-1, -1) + 1
= 0

TreeHeight(2)
= Max(0, -1) + 1
= 1

TreeHeight(3)
= Max(-1, -1) + 1
= 0

TreeHeight(1)
= Max(1, 0) + 1
= 2

---------------------------------------------------------
Recursion Tree
---------------------------------------------------------

TreeHeight(1)
│
├── TreeHeight(2)
│   ├── TreeHeight(4)
│   │   ├── TreeHeight(null) = -1
│   │   └── TreeHeight(null) = -1
│   │   Return 0
│   │
│   └── TreeHeight(null) = -1
│
│   Return 1
│
└── TreeHeight(3)
    ├── TreeHeight(null) = -1
    └── TreeHeight(null) = -1

    Return 0

Final:
TreeHeight(1)
= Max(1, 0) + 1
= 2

---------------------------------------------------------
Output
---------------------------------------------------------

Tree height is: 2
 */