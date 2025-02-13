using DataStructure.Linkedlist;

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
