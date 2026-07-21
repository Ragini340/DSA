// Written by Ragini. All rights reserved. 
using DataStructure.Linkedlist;

/*
 Time Complexity (TC):
---------------------
Let:
m = Number of nodes in List 1
n = Number of nodes in List 2

- Each node from both linked lists is visited exactly once.
- The while loop processes every node only once.
- After one list ends, the remaining nodes are attached in O(1) time.

Time Complexity = O(m + n)

------------------------------------------------------------

Space Complexity (SC):
----------------------
- No new linked list is created.
- Only a few pointer variables are used:
  head, tail, h1, h2, t1, t2

Extra Space = O(1)
 */
namespace DataStructure.LinkedList
{
    public class MergeTwoSortedLinkedLists
    {
        public Node MergeTwoSortedNodes(Node node1, Node node2)
        {
            Node head = null;
            Node tail = null;
            Node h1 = node1;
            Node h2 = node2;
            Node t1 = null;
            Node t2 = null;

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
                t1 = h1;
                t2 = h2.next;
            }

            while (t1 != null && t2 != null)
            {
                if (t1.data <= t2.data)
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

        public static void Main(String[] args)
        {
            MergeTwoSortedLinkedLists mergeTwoSortedLinkedLists = new MergeTwoSortedLinkedLists();
            Node head1 = new Node(2);
            head1.next = new Node(6);
            head1.next.next = new Node(10);
            head1.next.next.next = new Node(14);
            head1.next.next.next.next = new Node(19);

            Node head2 = new Node(3);
            head2.next = new Node(5);
            head2.next.next = new Node(9);
            head2.next.next.next = new Node(11);

            Node finalNode = mergeTwoSortedLinkedLists.MergeTwoSortedNodes(head1, head2);
            Console.WriteLine("Merged Linked List is: ");
            mergeTwoSortedLinkedLists.Traversal(finalNode);
        }

    }
}
/*
Input:
List 1: 2 -> 6 -> 10 -> 14 -> 19
List 2: 3 -> 5 -> 9 -> 11

-------------------------------------------------------
Initial Values
-------------------------------------------------------

h1 = 2
h2 = 3

Since 2 < 3

head = 2
tail = 2

t1 = 6
t2 = 3

Merged List:
2

-------------------------------------------------------
Iteration 1
-------------------------------------------------------

t1 = 6
t2 = 3

6 <= 3 ? No

tail.next = 3
tail = 3
t2 = 5

Merged List:
2 -> 3

-------------------------------------------------------
Iteration 2
-------------------------------------------------------

t1 = 6
t2 = 5

6 <= 5 ? No

tail.next = 5
tail = 5
t2 = 9

Merged List:
2 -> 3 -> 5

-------------------------------------------------------
Iteration 3
-------------------------------------------------------

t1 = 6
t2 = 9

6 <= 9 ? Yes

tail.next = 6
tail = 6
t1 = 10

Merged List:
2 -> 3 -> 5 -> 6

-------------------------------------------------------
Iteration 4
-------------------------------------------------------

t1 = 10
t2 = 9

10 <= 9 ? No

tail.next = 9
tail = 9
t2 = 11

Merged List:
2 -> 3 -> 5 -> 6 -> 9

-------------------------------------------------------
Iteration 5
-------------------------------------------------------

t1 = 10
t2 = 11

10 <= 11 ? Yes

tail.next = 10
tail = 10
t1 = 14

Merged List:
2 -> 3 -> 5 -> 6 -> 9 -> 10

-------------------------------------------------------
Iteration 6
-------------------------------------------------------

t1 = 14
t2 = 11

14 <= 11 ? No

tail.next = 11
tail = 11
t2 = null

Merged List:
2 -> 3 -> 5 -> 6 -> 9 -> 10 -> 11

-------------------------------------------------------
Exit Loop
-------------------------------------------------------

Condition:
t1 != null
t2 == null

Attach remaining nodes of List 1

tail.next = 14 -> 19

-------------------------------------------------------
Final Merged List
-------------------------------------------------------

2 -> 3 -> 5 -> 6 -> 9 -> 10 -> 11 -> 14 -> 19

-------------------------------------------------------
Pointer Summary
-------------------------------------------------------

head -> 2

tail movement:

2
↓
3
↓
5
↓
6
↓
9
↓
10
↓
11

Remaining nodes:
14 -> 19

-------------------------------------------------------
Output
-------------------------------------------------------

2
3
5
6
9
10
11
14
19
*/