using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void inSertAtBeginning(int element)
        {
            Node node = new Node(element);
            node.next = head;
            head = node;
        }

        public void insertNodeAtEnd(int element)
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

        public void traversal()
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

        public static void Main(string[] args)
        {
            SingleLikedList singleLikedList = new SingleLikedList();
            Console.WriteLine("Insert node at beginning: ");

            for (int i = 0; i <= 5; i++)
            {
                singleLikedList.inSertAtBeginning(i);
            }

            singleLikedList.traversal();
            Console.WriteLine();
            Console.WriteLine("Insert node at end: ");
            singleLikedList.insertNodeAtEnd(5);
            singleLikedList.traversal();
        }

    }
}
