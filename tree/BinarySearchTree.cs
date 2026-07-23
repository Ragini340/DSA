/*
===========================
TIME COMPLEXITY (TC)
===========================

FindNodeInBinaryTree()

Best Case:
O(1)
- Element is found at the root.

Average Case:
O(log n)
- For a balanced Binary Search Tree.

Worst Case:
O(n)
- Tree becomes skewed (like a linked list).


--------------------------------------------

InsertNodeInBinarySearchTree()

Best Case:
O(1)
- New node is inserted as an immediate child of the root.

Average Case:
O(log n)
- Balanced BST.

Worst Case:
O(n)
- Skewed BST.

InOrder Traversal after insertion:
O(n)

Overall Time Complexity of InsertNodeInBinarySearchTree():
Best Case:    O(n)   (Traversal dominates)
Average Case: O(n)
Worst Case:   O(n)

(Without the InOrder() call, insertion alone would be
Best/Average: O(log n), Worst: O(n).)

==================================================

SPACE COMPLEXITY (SC)
===========================

FindNodeInBinaryTree():
O(1)
- Uses only a few pointers.

InsertNodeInBinarySearchTree():
O(1)
- Uses only temp and parentNode references.

InOrder Traversal:
O(h)

where h = height of the tree.

Balanced BST:
O(log n)

Skewed BST:
O(n)

Overall Space Complexity of InsertNodeInBinarySearchTree():
Balanced BST: O(log n)
Worst Case:   O(n)

(The extra space comes only from the recursive InOrder traversal.)
*/
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
/*
Initial BST:

                 8
               /   \
              4     13
             / \   /  \
            1   7 10  15
                         \
                          17

----------------------------------
1. FindNodeInBinaryTree(root, 13)
----------------------------------

temp = 8

Iteration 1
-----------
temp.data = 8

8 == 13 ? No
8 < 13 ? Yes

Move right

temp = 13


Iteration 2
-----------
temp.data = 13

13 == 13 ? Yes

Return 1

Output:
Given element is found in Binary Search Tree

==================================================

2. InsertNodeInBinarySearchTree(root, 14)

Goal:
Insert 14 while maintaining BST property.

Initial values

temp = 8
parentNode = null

----------------------------------

Iteration 1

temp = 8

parentNode = 8

8 == 14 ? No
8 < 14 ? Yes

Move right

temp = 13

----------------------------------

Iteration 2

temp = 13

parentNode = 13

13 == 14 ? No
13 < 14 ? Yes

Move right

temp = 15

----------------------------------

Iteration 3

temp = 15

parentNode = 15

15 == 14 ? No
15 < 14 ? No

Move left

temp = null

Loop ends.

Current parentNode = 15

----------------------------------

Insertion

parentNode == null ? No

15 < 14 ? No

Insert on LEFT of 15

parentNode.left = new Node(14)

Updated BST

                 8
               /   \
              4     13
             / \   /  \
            1   7 10  15
                      / \
                     14 17

==================================================

InOrder Traversal

Rule:
Left -> Root -> Right

Traversal sequence

Visit 1
Visit 4
Visit 7
Visit 8
Visit 10
Visit 13
Visit 14
Visit 15
Visit 17

Output

1 4 7 8 10 13 14 15 17

==================================================
Final Console Output

Given element is found in Binary Search Tree
1 4 7 8 10 13 14 15 17

==================================================
*/