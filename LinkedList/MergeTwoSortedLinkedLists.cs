// Written by Ragini. All rights reserved. 
using DataStructure.Linkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class MergeTwoSortedLinkedLists
    {
        public Node mergeTwoSortedNodes(Node node1, Node node2)
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

        public void traversal(Node head)
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

            Node finalNode = mergeTwoSortedLinkedLists.mergeTwoSortedNodes(head1, head2);
            Console.WriteLine("Merged Linked List is: ");
            mergeTwoSortedLinkedLists.traversal(finalNode);
        }

    }
}
