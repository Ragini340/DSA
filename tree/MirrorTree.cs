namespace DataStructure.Tree
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
/*
Input Tree

        1
      /   \
     2     3
    / \   / \
   4   5 6   7

Inorder Traversal (Before Mirror)

4 2 5 1 6 3 7

-------------------------------------------
Call 1
-------------------------------------------

MirrorTrees(1)

leftNode  = MirrorTrees(2)
rightNode = MirrorTrees(3)

-------------------------------------------
Call 2
-------------------------------------------

MirrorTrees(2)

leftNode  = MirrorTrees(4)
rightNode = MirrorTrees(5)

-------------------------------------------
Call 3
-------------------------------------------

MirrorTrees(4)

leftNode  = MirrorTrees(null) -> null
rightNode = MirrorTrees(null) -> null

Swap

left  = null
right = null

Return Node 4

-------------------------------------------
Call 4
-------------------------------------------

MirrorTrees(5)

leftNode  = null
rightNode = null

Swap

left  = null
right = null

Return Node 5

-------------------------------------------
Back to Node 2
-------------------------------------------

Before Swap

      2
     / \
    4   5

Returned

leftNode  = 4
rightNode = 5

Code Executed

root.left  = rightNode;
root.right = leftNode;

After Swap

      2
     / \
    5   4

Return Node 2

-------------------------------------------
Call 5
-------------------------------------------

MirrorTrees(3)

leftNode  = MirrorTrees(6)
rightNode = MirrorTrees(7)

-------------------------------------------
Call 6
-------------------------------------------

MirrorTrees(6)

leftNode  = null
rightNode = null

Return Node 6

-------------------------------------------
Call 7
-------------------------------------------

MirrorTrees(7)

leftNode  = null
rightNode = null

Return Node 7

-------------------------------------------
Back to Node 3
-------------------------------------------

Before Swap

      3
     / \
    6   7

Returned

leftNode  = 6
rightNode = 7

Code Executed

root.left  = rightNode;
root.right = leftNode;

After Swap

      3
     / \
    7   6

Return Node 3

-------------------------------------------
Back to Root (1)
-------------------------------------------

Current Tree

        1
      /   \
     2     3
    / \   / \
   5   4 7   6

Returned

leftNode  = 2
rightNode = 3

Code Executed

root.left  = rightNode;
root.right = leftNode;

Final Mirrored Tree

        1
      /   \
     3     2
    / \   / \
   7   6 5   4

-------------------------------------------
Final Inorder Traversal
-------------------------------------------

7 3 6 1 5 2 4

-------------------------------------------
Recursion Call Stack
-------------------------------------------

MirrorTrees(1)
├── MirrorTrees(2)
│   ├── MirrorTrees(4)
│   └── MirrorTrees(5)
└── MirrorTrees(3)
    ├── MirrorTrees(6)
    └── MirrorTrees(7)
*/