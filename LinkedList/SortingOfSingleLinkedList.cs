using DataStructure.Linkedlist;

/*
=========================================================
TIME COMPLEXITY
=========================================================

Finding Middle      : O(n)

Merge Two Lists     : O(n)

Recursion Levels    : O(log n)

Overall Time        : O(n log n)
=========================================================
SPACE COMPLEXITY
=========================================================

Recursive Stack     : O(log n)

Extra Linked List   : O(1)
 */
namespace DataStructure.LinkedList
{
    public class SortingOfSingleLinkedList
    {
        Node SortList(Node node)
        {
            if (node == null || node.next == null)
            {
                return node;
            }

            Node middleNode = GetMiddleNode(node);
            Node head1 = node;
            Node head2 = middleNode.next;
            middleNode.next = null;
            Node h1 = SortList(head1);
            Node h2 = SortList(head2);
            return MergeSortedList(h1, h2);
        }

        private Node MergeSortedList(Node node1, Node node2)
        {
            Node head = null;
            Node t1 = null;
            Node t2 = null;
            Node h1 = node1;
            Node h2 = node2;
            Node tail = null;

            if (h1 == null)
            {
                return h2;
            }

            if (h2 == null)
            {
                return h1;
            }

            if (h1.data < h2.data)
            {
                head = h1;
                tail = h1;
                t1 = h1.next;
                t2 = h2;
            }
            else
            {
                head = h2;
                tail = h2;
                t2 = h2.next;
                t2 = h1;
            }

            while (t1 != null && t2 != null)
            {
                if (t1.data < t2.data)
                {
                    tail.next = t1;
                    t1 = t1.next;
                    tail = tail.next;
                }
                else
                {
                    tail.next = t2;
                    t2 = t2.next;
                    tail = tail.next;
                }
            }

            if (t1 == null)
            {
                tail.next = t2;
            }


            if (t2 == null)
            {
                tail.next = t1;
            }
            return head;
        }

        public Node GetMiddleNode(Node head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }

            Node slow = head;
            Node fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        public void Traversal(Node head)
        {
            Node tNode = head;
            if (tNode == null)
            {
                Console.WriteLine("Empty List");
            }

            while (tNode != null)
            {
                Console.WriteLine(tNode.data);
                tNode = tNode.next;
            }

        }

        public static void Main(string[] args)
        {
            Node head = new Node(10);
            head.next = new Node(3);
            head.next.next = new Node(7);
            head.next.next.next = new Node(9);
            head.next.next.next.next = new Node(5);
            head.next.next.next.next.next = new Node(4);
            head.next.next.next.next.next.next = new Node(11);

            SortingOfSingleLinkedList sortingOfSingleLinkedList = new SortingOfSingleLinkedList();
            Node node = sortingOfSingleLinkedList.SortList(head);
            sortingOfSingleLinkedList.Traversal(node);
        }
    }
}
/*
Input Linked List

10 → 3 → 7 → 9 → 5 → 4 → 11

=========================================================
STEP 1 : FIRST CALL
=========================================================

SortList(10 → 3 → 7 → 9 → 5 → 4 → 11)

Find Middle using Slow and Fast Pointer

Initially

Slow = 10
Fast = 10

Iteration 1

Slow = 3
Fast = 7

Iteration 2

Slow = 7
Fast = 5

Iteration 3

Slow = 9
Fast = 11

Fast.Next becomes NULL.

Middle Node = 9

Split the List

Head1

10 → 3 → 7 → 9

Head2

5 → 4 → 11


Recursive Calls

SortList(10 → 3 → 7 → 9)

SortList(5 → 4 → 11)

=========================================================
STEP 2 : SORT LEFT HALF
=========================================================

Input

10 → 3 → 7 → 9

Middle Node = 3

Split

10 → 3

7 → 9

---------------------------------------------------------
Sort (10 → 3)
---------------------------------------------------------

Middle = 10

Split

10

3

Both lists contain one node.

Merge

Compare

10 vs 3

3 is smaller.

Merged List

3 → 10

---------------------------------------------------------
Sort (7 → 9)
---------------------------------------------------------

Middle = 7

Split

7

9

Merge

Compare

7 vs 9

7 is smaller.

Merged List

7 → 9

---------------------------------------------------------
Merge Both Sorted Lists
---------------------------------------------------------

List 1

3 → 10

List 2

7 → 9

Comparison

3 < 7

Result

3

Compare

10 > 7

Result

3 → 7

Compare

10 > 9

Result

3 → 7 → 9

Remaining

10

Final Left Sorted List

3 → 7 → 9 → 10

=========================================================
STEP 3 : SORT RIGHT HALF
=========================================================

Input

5 → 4 → 11

Middle = 4

Split

5 → 4

11

---------------------------------------------------------
Sort (5 → 4)
---------------------------------------------------------

Middle = 5

Split

5

4

Merge

Compare

5 > 4

Result

4 → 5

---------------------------------------------------------
Merge
---------------------------------------------------------

List 1

4 → 5

List 2

11

Compare

4 < 11

Result

4

Compare

5 < 11

Result

4 → 5

Remaining

11

Final Right Sorted List

4 → 5 → 11

=========================================================
STEP 4 : FINAL MERGE
=========================================================

Left List

3 → 7 → 9 → 10

Right List

4 → 5 → 11


Comparison 1

3 < 4

Result

3


Comparison 2

7 > 4

Result

3 → 4


Comparison 3

7 > 5

Result

3 → 4 → 5


Comparison 4

7 < 11

Result

3 → 4 → 5 → 7


Comparison 5

9 < 11

Result

3 → 4 → 5 → 7 → 9


Comparison 6

10 < 11

Result

3 → 4 → 5 → 7 → 9 → 10


Remaining Node

11

Final Sorted List

3 → 4 → 5 → 7 → 9 → 10 → 11

=========================================================
RECURSION TREE
=========================================================

                      10 3 7 9 5 4 11
                             |
               ----------------------------
               |                          |
          10 3 7 9                    5 4 11
            |    |                    |    |
         10 3   7 9                 5 4    11
          | |    | |                 | |
         10 3    7 9                5 4
          |       |                  |
        Merge   Merge              Merge
          |       |                  |
       3 10     7 9               4 5
            \      /                 |
             Merge                Merge
               |                    |
         3 7 9 10              4 5 11
                  \            /
                   Final Merge
                        |
           3 4 5 7 9 10 11
 */