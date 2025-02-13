using DataStructure.Linkedlist;

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
                singleLikedList.InSertAtBeginning(i);
            }
            singleLikedList.Traversal();
            Console.WriteLine();

            //Case2: Insert node at end
            Console.WriteLine("Insert node at end: ");
            singleLikedList.InsertNodeAtEnd(6);
            singleLikedList.Traversal();
            Console.WriteLine();

            //Case3: Insert node before a node
            Console.WriteLine("Insert node before a node: ");
            singleLikedList.InsertNodeBeforeANode(99, 5);
            singleLikedList.Traversal();
            Console.WriteLine();

            //Case4: Insert node before last node
            Console.WriteLine("Insert node after a node: ");
            singleLikedList.InsertNodeBeforeANode(100, 6);
            singleLikedList.Traversal();
            Console.WriteLine();

            //Case5: Reverse a LinkedList
            Console.WriteLine("Reverse the LinkedList");
            singleLikedList.Reverse();
            singleLikedList.Traversal();
            Console.WriteLine();
        }

    }
}
