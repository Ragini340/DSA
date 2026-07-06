namespace DataStructure.Tree
{
    /*Time Complexity: O(N)
    Auxiliary Space: If we do not consider the size of the stack for function calls then O(1) otherwise O(h) where h is the height of the tree.*/

    /*
    Time Complexity (TC)
    Preorder Traversal:
    - Visits every node exactly once.
    - Time Complexity = O(N)

    Inorder Traversal:
    - Visits every node exactly once.
    - Time Complexity = O(N)

    Postorder Traversal:
    - Visits every node exactly once.
    - Time Complexity = O(N)

    Where:
    N = Number of nodes in the binary tree.

    --------------------------------------------------
    Space Complexity (SC)

    Recursive traversal uses the function call stack.

    Best Case (Balanced Tree):
    - Height of tree = log N
    - Space Complexity = O(log N)

    Worst Case (Skewed Tree):
    - Height of tree = N
    - Space Complexity = O(N)

    Overall Auxiliary Space = O(h)

    Where:
    h = Height of the binary tree.

    Worst Case:
    TC = O(N)
    SC = O(N)

    Balanced Tree:
    TC = O(N)
    SC = O(log N)
    */
    public class BinaryTreeTraversals
    {
        public static void Preorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.data + " ");
            Preorder(root.left);
            Preorder(root.right);
        }

        public static void Inorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Inorder(root.left);
            Console.WriteLine(root.data + " ");
            Inorder(root.right);
        }

        public static void Postorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Postorder(root.left);
            Postorder(root.right);
            Console.WriteLine(root.data + " ");
        }

    }
}

/*
Tree:

        1
      /   \
     2     3
    / \   / \
   4   5 6   7

----------------------------------
Preorder (Root -> Left -> Right)
----------------------------------

Preorder(1)
Print 1

    Preorder(2)
    Print 2

        Preorder(4)
        Print 4
        Left = null
        Right = null
        Return

        Preorder(5)
        Print 5
        Left = null
        Right = null
        Return

    Return

    Preorder(3)
    Print 3

        Preorder(6)
        Print 6
        Return

        Preorder(7)
        Print 7
        Return

Return

Output:
1 2 4 5 3 6 7

----------------------------------
Inorder (Left -> Root -> Right)
----------------------------------

Inorder(1)

    Inorder(2)

        Inorder(4)
        Print 4

    Print 2

        Inorder(5)
        Print 5

Print 1

    Inorder(3)

        Inorder(6)
        Print 6

    Print 3

        Inorder(7)
        Print 7

Output:
4 2 5 1 6 3 7

----------------------------------
Postorder (Left -> Right -> Root)
----------------------------------

Postorder(1)

    Postorder(2)

        Postorder(4)
        Print 4

        Postorder(5)
        Print 5

    Print 2

    Postorder(3)

        Postorder(6)
        Print 6

        Postorder(7)
        Print 7

    Print 3

Print 1

Output:
4 5 2 6 7 3 1
*/