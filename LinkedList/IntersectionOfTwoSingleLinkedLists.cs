namespace DataStructure.LinkedList
{
    public class Node1
    {
        public int data;
        public Node1 next;
        public Node1(int data)
        {
            this.data = data;
            next = null;
        }
    }

    public class IntersectionOfTwoSingleLinkedLists
    {
        public void Print(Node1 node1)
        {
            while (node1 != null)
            {
                Console.WriteLine(node1.data);
                node1 = node1.next;
            }
        }

        //Method1: Using Hashset
        /*Time complexity: O(M + N), where M and N are the lengths of the two lists.
        Space complexity: O(M + N)*/
        public void FindPointOfIntersectionUsingHashSet(Node1 node11, Node1 node12)
        {
            HashSet<Node1> nodelist = new HashSet<Node1>();
            while (node11 != null)
            {
                nodelist.Add(node11);
                node11 = node11.next;
            }

            while (node12 != null)
            {
                if (nodelist.Contains(node12))
                {
                    Console.WriteLine("Point of intersection is " + node12.data);
                    break;
                }
                node12 = node12.next;
            }
        }

        //Method2
        /*Time Complexity: O(M* N), where M and N are number of nodes in the two linked list.
        Space Complexity: O(1)*/
        public static int FindPointOfIntersectionMethod2(Node1 node11, Node1 node12)
        {
            int pointOfIntersection = 0;

            while (node11 != null)
            {
                Node1 secondNode = node12;
                while (secondNode != null)
                {
                    if (secondNode.data == node11.data)
                    {
                        pointOfIntersection = secondNode.data;
                        return secondNode.data;
                    }
                    else
                    {
                        secondNode = secondNode.next;
                    }
                }
                node11 = node11.next;
            }
            return pointOfIntersection;
        }

        public static void Main(String[] args)
        {
            Node1 node11 = new Node1(3);
            node11.next = new Node1(6);
            node11.next.next = new Node1(9);
            node11.next.next.next = new Node1(15);
            node11.next.next.next.next = new Node1(30);

            Node1 node12 = new Node1(10);
            node12.next = node11.next.next.next;
            node12.next.next = node11.next.next.next.next;

            IntersectionOfTwoSingleLinkedLists intersectionOfTwoSingleLinkedLists = new IntersectionOfTwoSingleLinkedLists();
            Console.WriteLine("Node11 list's elements are: ");
            intersectionOfTwoSingleLinkedLists.Print(node11);
            Console.WriteLine("Node12 list's elements are: ");
            intersectionOfTwoSingleLinkedLists.Print(node12);

            intersectionOfTwoSingleLinkedLists.FindPointOfIntersectionUsingHashSet(node11, node12);
            Console.WriteLine();

            int insertNode1 = IntersectionOfTwoSingleLinkedLists.FindPointOfIntersectionMethod2(node11, node12);
            Console.WriteLine("Point of intersection is using Method2: " + insertNode1);
        }

    }
}
