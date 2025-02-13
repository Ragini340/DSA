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
            if(last == null)
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
                while(last.next != null)
                {
                    if(last.next.data == item)
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
            if(last == null)
            {
                Console.WriteLine("Empty LinkedList");
            }
            else if(last.data == item)
            {
                node.next = last.next;
                last.next = node;
            }
            else
            {
                bool itemFound = false; 
                while(last != null)
                {
                    if(last.data == item)
                    {
                        node.next = last.next;
                        last.next = node;
                        itemFound = true;
                        break;
                    }
                    last = last.next;
                }
                if(!itemFound)
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
            if(temp == null)
            {
                return;
            }
            PrintReverse(temp.next);
            Console.WriteLine(" " + temp.data);
        }

        public void Reverse()
        {
            if(head == null)
            {
                return;
            }
            Node prev = null;
            Node current = head;
            Node temp = null;
            while(current != null)
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
