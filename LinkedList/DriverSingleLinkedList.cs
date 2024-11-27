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
            SingleLikedList singleLikedList = new SingleLikedList();
            Console.WriteLine("Insert node at beginning: ");

            for (int i = 0; i <= 5; i++)
            {
                singleLikedList.inSertAtBeginning(i);
            }

            singleLikedList.traversal();
            Console.WriteLine();
            Console.WriteLine("Insert node at end: ");
            singleLikedList.insertNodeAtEnd(6);
            singleLikedList.traversal();
            Console.WriteLine();

            Console.WriteLine("Insert node before a node: ");
            singleLikedList.insertNodeBeforeANode(99, 5);
            singleLikedList.traversal();           
        }

    }
}
