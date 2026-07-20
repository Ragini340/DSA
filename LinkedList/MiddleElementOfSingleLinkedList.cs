using DataStructure.Linkedlist;

/*
 Time Complexity (TC): O(n)

Reason:
- The slow pointer moves one node at a time.
- The fast pointer moves two nodes at a time.
- Although there are two pointers, the list is traversed only once.
- The loop runs approximately n/2 times, which simplifies to O(n).

Space Complexity (SC): O(1)

Reason:
- Only two extra pointers (slow and fast) are used.
- No additional data structures are created.
- The space used does not depend on the size of the linked list.
 */
namespace DataStructure.LinkedList
{
    public class MiddleElementOfSingleLinkedList
    {
        public Node MiddleElementInLinkedList(Node head)
        {
            Node slow = head;
            Node fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        public static void Main(string[] args)
        {
            Node head = new Node(10);
            head.next = new Node(20);
            head.next.next = new Node(30);
            head.next.next.next = new Node(40);
            head.next.next.next.next = new Node(50);
            head.next.next.next.next.next = new Node(60);

            MiddleElementOfSingleLinkedList middleElementOfSingleLinkedList = new MiddleElementOfSingleLinkedList();
            Node isMiddleElementFound = middleElementOfSingleLinkedList.MiddleElementInLinkedList(head);
            Console.WriteLine("Middle element is: " + isMiddleElementFound.data);
        }

    }
}
/*
Linked List:
10 -> 20 -> 30 -> 40 -> 50 -> 60 -> null

Initial:
slow = 10
fast = 10

----------------------------------------------------------
Iteration | slow before | fast before | slow after | fast after
----------------------------------------------------------
1         | 10          | 10          | 20         | 30
2         | 20          | 30          | 30         | 50
----------------------------------------------------------

Now:
fast = 50

Condition Check:
fast.next != null      -> 60 != null       -> true
fast.next.next != null -> null != null     -> false

Loop stops.

Return slow = 30

Output:
Middle element is: 30
*/