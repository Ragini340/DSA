using DataStructure.Linkedlist;

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