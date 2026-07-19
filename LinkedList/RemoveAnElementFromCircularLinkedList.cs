using DataStructure.Linkedlist;

/*
====================================================
Time Complexity
====================================================
Add()
Worst Case : O(n)

Remove()
Best Case  : O(1)  (Only node or Head)
Worst Case : O(n)

PrintList()
O(n)

Space Complexity
O(1)
*/
namespace DataStructure.LinkedList
{
    public class RemoveAnElementFromCircularLinkedList
    {
        public Node Head { get; set; }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                newNode.next = Head;
            }
            else
            {
                Node temp = Head;
                while (temp.next != Head)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                newNode.next = Head;
            }
        }

        public void PrintList()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = Head;
            do
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            } while (temp != Head);
            Console.WriteLine();
        }

        public void Remove(int data)
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = Head;
            Node previous = null;

            //Case 1: The node to be removed is the only node in the list
            if (Head.data == data && Head.next == Head)
            {
                Head = null;
                Console.WriteLine($"Node with data {data} removed.");
                return;
            }

            //Case 2: The node to be removed is the head node
            if (Head.data == data)
            {
                while (current.next != Head)
                {
                    current = current.next;
                }

                current.next = Head.next;
                Head = Head.next;
                Console.WriteLine($"Node with data {data} removed.");
                return;
            }

            //Case 3: Node is somewhere in the middle or end of the list
            do
            {
                previous = current;
                current = current.next;

                if (current.data == data)
                {
                    previous.next = current.next;
                    Console.WriteLine($"Node with data {data} removed.");
                    return;
                }
            } while (current != Head);

            Console.WriteLine($"Node with data {data} not found.");
        }

        public static void Main(string[] args)
        {
            RemoveAnElementFromCircularLinkedList list = new RemoveAnElementFromCircularLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("Circular linked list element:- ");
            list.PrintList();

            list.Remove(3);
            Console.WriteLine("\nAfter removing 3 linked list element:- ");
            list.PrintList();

            list.Remove(6);
            list.Remove(1);
            Console.WriteLine("\nAfter removing 1 linked list element:- ");
            list.PrintList();
        }

    }
}
/*
Initial Operations:
-------------------
Add(1)
Head -> 1
1 -> points back to itself

List:
1 -> 1

-------------------
Add(2)

Traverse to last node (1)

1.next = 2
2.next = Head(1)

List:
1 -> 2 -> 1

-------------------
Add(3)

Traverse:
1 -> 2

2.next = 3
3.next = Head

List:
1 -> 2 -> 3 -> 1

-------------------
Add(4)

Traverse:
1 -> 2 -> 3

3.next = 4
4.next = Head

List:
1 -> 2 -> 3 -> 4 -> 1

-------------------
Add(5)

Traverse:
1 -> 2 -> 3 -> 4

4.next = 5
5.next = Head

Final Circular List

Head
 |
 v
1 -> 2 -> 3 -> 4 -> 5
^                   |
|___________________|

Print Output:
1 2 3 4 5

====================================================
Remove(3)
====================================================

Head = 1

current = Head (1)
previous = null

Head.data != 3
Only one node? No

Case 3 begins

Iteration 1

previous = 1
current = 2

current.data == 3 ?
No

Iteration 2

previous = 2
current = 3

current.data == 3 ?
Yes

Delete node

previous.next = current.next

2 ------> 4

List becomes

Head
 |
 v
1 -> 2 -> 4 -> 5
^              |
|______________|

Output:
Node with data 3 removed.

Print List

1 2 4 5

====================================================
Remove(6)
====================================================

current = 1
previous = null

Traversal

1 -> 2 -> 4 -> 5 -> Head

Node 6 never found.

Output:
Node with data 6 not found.

List remains

1 -> 2 -> 4 -> 5

====================================================
Remove(1)
====================================================

Head.data == 1

This is Case 2 (Removing Head)

Find last node

current = 1
current = 2
current = 4
current = 5

Now current is last node.

Perform

current.next = Head.next

5.next = 2

Move Head

Head = Head.next

Head = 2

Updated List

Head
 |
 v
2 -> 4 -> 5
^         |
|_________|

Output:
Node with data 1 removed.

Print List

2 4 5

====================================================
Final Output
====================================================

Circular linked list element:-
1 2 3 4 5

Node with data 3 removed.

After removing 3 linked list element:-
1 2 4 5

Node with data 6 not found.

Node with data 1 removed.

After removing 1 linked list element:-
2 4 5
*/