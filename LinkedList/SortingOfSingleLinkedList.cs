using DataStructure.Linkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class SortingOfSingleLinkedList
    {
        Node sortList(Node node)
        {
            if(node == null || node.next == null)
            {
                return node;
            }

            Node middleNode = getMiddleNode(node);
            Node head1 = node;
            Node head2 = middleNode.next;
            middleNode.next = null;
            Node h1 = sortList(head1);
            Node h2 = sortList(head2);
            return mergeSortedList(h1, h2);
        }

        private Node mergeSortedList(Node node1, Node node2)
        {
            Node head = null;
            Node t1 = null;
            Node t2 = null;
            Node h1 = node1;
            Node h2 = node2;
            Node tail = null;

            if(h1 == null)
            {
                return h2;
            }

            if (h2 == null)
            {
                return h1;
            }

            if(h1.data <h2.data)
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

            while(t1 != null && t2 != null)
            {
                if(t1.data < t2.data)
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

            if(t1 == null)
            {
                tail.next = t2;
            }


            if (t2 == null)
            {
                tail.next = t1;
            }
            return head;
        }

        public Node getMiddleNode(Node head)
        {
            if(head == null)
            {
                return null;
            }

            if(head.next == null)
            {
                return head;
            }

            Node slow = head;
            Node fast = head;

            while(fast.next != null && fast.next.next != null)
            {
                slow = slow.next; 
                fast = fast.next.next;
            }
            return slow;
        }

        public void traversal(Node head)
        {
            Node tNode = head;
            if(tNode == null)
            {
                Console.WriteLine("Empty List");
            }

            while(tNode != null)
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
            Node node = sortingOfSingleLinkedList.sortList(head);
            sortingOfSingleLinkedList.traversal(node);
        }
    }
}
