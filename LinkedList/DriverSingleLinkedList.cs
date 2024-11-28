using DataStructure.Linkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class DriverSingleLinkedList
    {
        public static void Main(string[] args)
        {
            //Case1: Insert node at beginning
            SingleLikedList singleLikedList = new SingleLikedList();
            Console.WriteLine("Insert node at beginning: ");
            for (int i = 5; i >=0 ; i--)
            {
                singleLikedList.inSertAtBeginning(i);
            }
            singleLikedList.traversal();
            Console.WriteLine();

            //Case2: Insert node at end
            Console.WriteLine("Insert node at end: ");
            singleLikedList.insertNodeAtEnd(6);
            singleLikedList.traversal();
            Console.WriteLine();

            //Case3: Insert node before a node
            Console.WriteLine("Insert node before a node: ");
            singleLikedList.insertNodeBeforeANode(99, 5);
            singleLikedList.traversal();
            Console.WriteLine();

            //Case4: Insert node before last node
            Console.WriteLine("Insert node after a node: ");
            singleLikedList.insertNodeBeforeANode(100, 6);
            singleLikedList.traversal();
            Console.WriteLine();

            //Case5: Reverse a LinkedList
            Console.WriteLine("Reverse the LinkedList");
            singleLikedList.reverse();
            singleLikedList.traversal();
            Console.WriteLine();
        }

    }
}
