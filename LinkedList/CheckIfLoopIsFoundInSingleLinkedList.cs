using DataStructure.Linkedlist;

/*
Time Complexity:
O(N)

Space Complexity:
O(1)
*/
namespace DataStructure.LinkedList
{
    public class CheckIfLoopIsFoundInSingleLinkedList
    {
        /*Case1: To check if there is a loop found in the single linked list*/
        public bool FindLoopInLinkedList(Node head)
        {
            Node slow = head;
            Node fast = head;
            bool isCycle = false;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    isCycle = true;
                    break;
                }
            }
            return isCycle;
        }

        /*Case2: To find start point of a loop*/
        public Node FindStartPointOfALoop(Node head)
        {
            Node slow = head;
            Node fast = head;
            bool isCycle = false;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    isCycle = true;
                    break;
                }
            }

            if (isCycle)
            {
                slow = head;
                while (true)
                {
                    if (slow == fast)
                    {
                        return fast;
                    }
                    slow = slow.next;
                    fast = fast.next;
                }
            }
            else
            {
                return null;
            }
        }

        public static void Main(string[] args)
        {
            Node head = new Node(3);
            head.next = new Node(9);
            head.next.next = new Node(7);
            head.next.next.next = new Node(2);

            Node temp = head.next.next.next.next = new Node(8);
            temp.next = new Node(4);
            temp.next.next = new Node(16);
            temp.next.next.next = new Node(26);
            temp.next.next.next.next = new Node(96);
            temp.next.next.next.next.next = new Node(94);

            Node temp1 = temp.next.next.next.next.next.next = new Node(400);
            temp1.next = new Node(213);
            temp1.next.next = new Node(100);
            temp1.next.next.next = new Node(500);
            temp1.next.next.next.next = new Node(250);
            temp1.next.next.next.next.next = new Node(175);

            Node temp2 = temp1.next.next.next.next.next.next = new Node(32);
            temp2.next = temp.next.next.next.next;

            //Case1: To check if there is a loop found in the single linked list
            CheckIfLoopIsFoundInSingleLinkedList checkIfLoopIsFoundInSingleLinkedList = new CheckIfLoopIsFoundInSingleLinkedList();
            bool isLoopFound = checkIfLoopIsFoundInSingleLinkedList.FindLoopInLinkedList(head);
            Console.WriteLine("Is loop found in list ?" + isLoopFound);

            //Case2: To find start point of a loop
            Node startLoop = checkIfLoopIsFoundInSingleLinkedList.FindStartPointOfALoop(head);
            if (startLoop != null)
            {
                Console.WriteLine("Loop start node " + startLoop.data);
            }
            else
            {
                Console.WriteLine("There is no loop in the Single LinkedList");
            }
        }

    }
}
/*
Linked List Created:

3 -> 9 -> 7 -> 2 -> 8 -> 4 -> 16 -> 26 -> 96 -> 94
                                          |
                                          v
400 -> 213 -> 100 -> 500 -> 250 -> 175 -> 32
 ^                                         |
 |_________________________________________|

Loop starts at node 96.

---------------------------------------------------------
CASE 1 : FindLoopInLinkedList()
---------------------------------------------------------

Initially

slow = 3
fast = 3

Iteration 1
-----------
slow = 9
fast = 7

Iteration 2
-----------
slow = 7
fast = 8

Iteration 3
-----------
slow = 2
fast = 16

Iteration 4
-----------
slow = 8
fast = 96

Iteration 5
-----------
slow = 4
fast = 400

Iteration 6
-----------
slow = 16
fast = 100

Iteration 7
-----------
slow = 26
fast = 250

Iteration 8
-----------
slow = 96
fast = 32

Iteration 9
-----------
slow = 94
fast = 96

Iteration 10
------------
slow = 400
fast = 400

slow == fast

Loop detected.

Method returns TRUE.


Console Output

Is loop found in list ?True

=========================================================
CASE 2 : FindStartPointOfALoop()
=========================================================
Meeting point obtained at node 400.

Now

slow = head = 3
fast = 400

Move both one step at a time.

Step 1
------
slow = 9
fast = 213

Step 2
------
slow = 7
fast = 100

Step 3
------
slow = 2
fast = 500

Step 4
------
slow = 8
fast = 250

Step 5
------
slow = 4
fast = 175

Step 6
------
slow = 16
fast = 32

Step 7
------
slow = 26
fast = 96

Step 8
------
slow = 96
fast = 94

Step 9
------
slow = 94
fast = 400

Step 10
-------
slow = 400
fast = 213

Step 11
-------
slow = 213
fast = 100

Step 12
-------
slow = 100
fast = 500

Step 13
-------
slow = 500
fast = 250

Step 14
-------
slow = 250
fast = 175

Step 15
-------
slow = 175
fast = 32

Step 16
-------
slow = 32
fast = 96

Step 17
-------
slow = 96
fast = 94

Both pointers meet at node 96.

Loop starting node = 96


Console Output

Loop start node 96

=========================================================
FINAL OUTPUT
=========================================================

Is loop found in list ?True
Loop start node 96
=========================================================
*/