/*
------------------------------------------------------------
TIME COMPLEXITY
------------------------------------------------------------

Method 1 (HashSet)

Time Complexity : O(M + N)
Space Complexity : O(M)

------------------------------------------------------------

Method 2 (Nested Loop)

Time Complexity : O(M × N)
Space Complexity : O(1)
 */
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
/*
Initial Linked Lists

List1 (node11)

3 → 6 → 9 → 15 → 30 → NULL

List2 (node12)

10 → 15 → 30 → NULL

Note:
The nodes containing 15 and 30 are shared by both linked lists.
Both lists point to the same Node objects from node 15 onward.

------------------------------------------------------------
METHOD 1 : USING HASHSET
------------------------------------------------------------

Step 1 : Traverse List1 and insert every node into HashSet.

Iteration 1
Current Node = 3
HashSet = {3}

Iteration 2
Current Node = 6
HashSet = {3, 6}

Iteration 3
Current Node = 9
HashSet = {3, 6, 9}

Iteration 4
Current Node = 15
HashSet = {3, 6, 9, 15}

Iteration 5
Current Node = 30
HashSet = {3, 6, 9, 15, 30}

Now all nodes of List1 are stored in HashSet.

------------------------------------------------------------

Step 2 : Traverse List2 and check whether each node exists in HashSet.

Iteration 1

Current Node = 10

HashSet.Contains(10)?
No

Move to next node.

------------------------------------------------------------

Iteration 2

Current Node = 15

HashSet.Contains(15)?
Yes

Intersection Found.

Output

Point of intersection is 15

Method 1 stops here.

------------------------------------------------------------
METHOD 2 : NESTED LOOP
------------------------------------------------------------

Initially

pointOfIntersection = 0

------------------------------------------------------------

Outer Loop 1

node11 = 3

Compare with every node of List2

3 == 10 ? No
3 == 15 ? No
3 == 30 ? No

No match found.

Move node11 to next node.

------------------------------------------------------------

Outer Loop 2

node11 = 6

Compare with List2

6 == 10 ? No
6 == 15 ? No
6 == 30 ? No

No match found.

------------------------------------------------------------

Outer Loop 3

node11 = 9

Compare with List2

9 == 10 ? No
9 == 15 ? No
9 == 30 ? No

No match found.

------------------------------------------------------------

Outer Loop 4

node11 = 15

Compare with List2

15 == 10 ? No

15 == 15 ? Yes

pointOfIntersection = 15

Return 15

Output

Point of intersection is using Method2 : 15

------------------------------------------------------------
FINAL OUTPUT
------------------------------------------------------------

Node11 list's elements are:
3
6
9
15
30

Node12 list's elements are:
10
15
30

Point of intersection is 15

Point of intersection is using Method2 : 15
*/