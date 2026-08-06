using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Coding_Questions
{
    /*
    Question:
    You are given two non-empty linked lists representing two non-negative integers.

    The digits are stored in reverse order, and each of their nodes contains a single digit.
    Add the two numbers and return the sum as a linked list.

    Example:

    Input:
    l1 = [2,4,3]
    l2 = [5,6,4]

    Output:
    [7,0,8]

    Explanation:
    342 + 465 = 807

    Approach:
    1. Create a dummy node to build the result linked list.
    2. Traverse both linked lists simultaneously.
    3. Add corresponding digits along with carry.
    4. Store the digit value (sum % 10) in the new node.
    5. Update carry (sum / 10).
    6. Continue until both lists are empty and no carry remains.

    Time Complexity (TC): O(max(m,n))
    - Traverse both linked lists once.
    - m and n are the lengths of l1 and l2.

    Space Complexity (SC): O(max(m,n))
    - A new linked list is created to store the result.
    */
    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersSolution(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = carry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;
            }

            return dummy.next;
        }

        public static void Main(string[] args)
        {
            AddTwoNumbers solution = new AddTwoNumbers();

            // Input:
            // l1 = [2,4,3]
            // l2 = [5,6,4]

            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));

            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            ListNode result = solution.AddTwoNumbersSolution(l1, l2);

            Console.Write("Output: ");

            while (result != null)
            {
                Console.Write(result.val);

                if (result.next != null)
                {
                    Console.Write(" -> ");
                }

                result = result.next;
            }
        }
    }
}