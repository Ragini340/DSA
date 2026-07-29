namespace DataStructure.Linkedlist
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    public class SingleLikedList
    {
        Node head;

        /*Case1: Insert node at beginning
         * Time Complexity: O(1)
         * Space Complexity: O(1)
        */
        public void InSertAtBeginning(int element)
        {
            Node node = new Node(element);
            node.next = head;
            head = node;
        }

        /*Case2: Insert node at end
         * Time Complexity: O(N)
         * Space Complexity: O(1)
        */
        public void InsertNodeAtEnd(int element)
        {
            Node node = new Node(element);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node last = head;
                while (last.next != null)
                {
                    last = last.next;
                }
                last.next = node;
            }
        }

        /*Case3: Insert node before a node
        */
        public void InsertNodeBeforeANode(int element, int item)
        {
            Node node = new Node(element);
            Node last = head;
            if (last == null)
            {
                Console.WriteLine("Empty LinkedList");
            }
            else if (item == last.data)
            {
                node.next = last;
                head = node;
            }
            else
            {
                bool itemFound = false;
                while (last.next != null)
                {
                    if (last.next.data == item)
                    {
                        node.next = last.next;
                        last.next = node;
                        itemFound = true;
                        break;
                    }
                    last = last.next;
                }
                if (!itemFound)
                {
                    Console.WriteLine("Item is not available in LinkedList");
                }
            }
        }

        /*Case4: Insert node before last node
       */
        public void InsertNodeAfterANode(int element, int item)
        {
            Node node = new Node(element);
            Node last = head;
            if (last == null)
            {
                Console.WriteLine("Empty LinkedList");
            }
            else if (last.data == item)
            {
                node.next = last.next;
                last.next = node;
            }
            else
            {
                bool itemFound = false;
                while (last != null)
                {
                    if (last.data == item)
                    {
                        node.next = last.next;
                        last.next = node;
                        itemFound = true;
                        break;
                    }
                    last = last.next;
                }
                if (!itemFound)
                {
                    Console.WriteLine("Item is unavailable");
                }
            }
        }

        /*Case5: Reverse a LinkedList*/
        public void ReverseLinkedList()
        {
            Node temp = head;
            PrintReverse(temp);
        }

        private void PrintReverse(Node temp)
        {
            if (temp == null)
            {
                return;
            }
            PrintReverse(temp.next);
            Console.WriteLine(" " + temp.data);
        }

        public void Reverse()
        {
            if (head == null)
            {
                return;
            }
            Node prev = null;
            Node current = head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        public void Traversal()
        {
            Node tNode = head;
            if (tNode == null)
            {
                Console.WriteLine("Empty list");
                Console.WriteLine();
            }
            while (tNode != null)
            {
                Console.WriteLine(tNode.data);
                tNode = tNode.next;
            }
        }

    }
}
/*
Initial:
Head = NULL
-------------------------------------------------
1. InsertAtBeginning(30)
-------------------------------------------------
Head
 ↓
30 -> NULL

-------------------------------------------------
2. InsertAtBeginning(20)
-------------------------------------------------
Head
 ↓
20 -> 30 -> NULL

-------------------------------------------------
3. InsertAtBeginning(10)
-------------------------------------------------
Head
 ↓
10 -> 20 -> 30 -> NULL

-------------------------------------------------
4. InsertNodeAtEnd(40)
-------------------------------------------------
Traverse:
10 -> 20 -> 30

Attach 40 at the end.

Head
 ↓
10 -> 20 -> 30 -> 40 -> NULL

-------------------------------------------------
5. InsertNodeAtEnd(50)
-------------------------------------------------
Traverse:
10 -> 20 -> 30 -> 40

Attach 50 at the end.

Head
 ↓
10 -> 20 -> 30 -> 40 -> 50 -> NULL

-------------------------------------------------
6. InsertNodeBeforeANode(25, 30)
-------------------------------------------------
Find node before 30 (i.e., 20)

Before:
10 -> 20 -> 30 -> 40 -> 50

After:
Head
 ↓
10 -> 20 -> 25 -> 30 -> 40 -> 50 -> NULL

-------------------------------------------------
7. InsertNodeAfterANode(45, 40)
-------------------------------------------------
Find node 40

Before:
10 -> 20 -> 25 -> 30 -> 40 -> 50

After:
Head
 ↓
10 -> 20 -> 25 -> 30 -> 40 -> 45 -> 50 -> NULL

-------------------------------------------------
8. ReverseLinkedList()
-------------------------------------------------
Only prints in reverse.

Output:
50
45
40
30
25
20
10

Original list remains unchanged.

-------------------------------------------------
9. Reverse()
-------------------------------------------------

Iteration 1
Prev = 10
Current = 20

10 -> NULL

Iteration 2
Prev = 20
Current = 25

20 -> 10 -> NULL

Iteration 3
Prev = 25
Current = 30

25 -> 20 -> 10 -> NULL

Iteration 4
Prev = 30
Current = 40

30 -> 25 -> 20 -> 10 -> NULL

Iteration 5
Prev = 40
Current = 45

40 -> 30 -> 25 -> 20 -> 10 -> NULL

Iteration 6
Prev = 45
Current = 50

45 -> 40 -> 30 -> 25 -> 20 -> 10 -> NULL

Iteration 7
Prev = 50
Current = NULL

Final List:

Head
 ↓
50 -> 45 -> 40 -> 30 -> 25 -> 20 -> 10 -> NULL

Traversal Output:
50
45
40
30
25
20
10
*/