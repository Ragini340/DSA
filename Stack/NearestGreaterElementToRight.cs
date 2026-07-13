namespace DataStructure.Stack
{
    /*
	 Nearest greater element in the right hand side.
	 Traverse from right to left to get right hand side greater element.
    */
    /*===========================================================
    Time Complexity
    ===========================================================

    O(n)

    Each element is pushed into the stack once and popped at most once.

    ===========================================================
    Space Complexity
    ===========================================================

    O(n)

    Extra space is used for:
    1. Stack
    2. Result List

    ===========================================================
    */

    public class NearestGreaterElementToRight
    {
        public static List<int> NearestGreaterElementRightSide(List<int> input)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                //Pop all less than equal to elements 
                while (stack.Count > 0 && stack.Peek() <= input[i])
                {
                    stack.Pop();
                }
                //Update result
                if (stack.Count == 0)
                {
                    result.Add(-1);
                }
                else
                {
                    result.Add(stack.Peek());
                }
                //Push element in stack 
                stack.Push(input[i]);
            }

            //Reverse result to traverse element from left to right
            result.Reverse();
            return result;
        }

        public static void Main(string[] args)
        {
            List<int> input = new List<int> { 9, 7, 3, 5, 4, 2, 6, 1, 8 };
            List<int> result = NearestGreaterElementRightSide(input);
            Console.WriteLine("Nearest greater element in right for the given each list's element: " + string.Join(", ", result));
        }

    }
}
/*
Input:
-----------------------------------------------------------
[9, 7, 3, 5, 4, 2, 6, 1, 8]

Traversal Direction:
-----------------------------------------------------------
Right  -----------------------------> Left

Initial:
-----------------------------------------------------------
Stack  = []
Result = []

===========================================================
Iteration 1
===========================================================
Current Element = 8

Stack Before = []

No element in stack.

Nearest Greater = -1

Result = [-1]

Push 8

Stack After = [8]

===========================================================
Iteration 2
===========================================================
Current Element = 1

Stack Before = [8]

Top(8) > 1

Nearest Greater = 8

Result = [-1, 8]

Push 1

Stack After = [8, 1]

===========================================================
Iteration 3
===========================================================
Current Element = 6

Stack Before = [8, 1]

Pop 1 (<=6)

Stack = [8]

Top(8) > 6

Nearest Greater = 8

Result = [-1, 8, 8]

Push 6

Stack After = [8, 6]

===========================================================
Iteration 4
===========================================================
Current Element = 2

Stack Before = [8, 6]

Top(6) > 2

Nearest Greater = 6

Result = [-1, 8, 8, 6]

Push 2

Stack After = [8, 6, 2]

===========================================================
Iteration 5
===========================================================
Current Element = 4

Stack Before = [8, 6, 2]

Pop 2 (<=4)

Stack = [8, 6]

Top(6) > 4

Nearest Greater = 6

Result = [-1, 8, 8, 6, 6]

Push 4

Stack After = [8, 6, 4]

===========================================================
Iteration 6
===========================================================
Current Element = 5

Stack Before = [8, 6, 4]

Pop 4 (<=5)

Stack = [8, 6]

Top(6) > 5

Nearest Greater = 6

Result = [-1, 8, 8, 6, 6, 6]

Push 5

Stack After = [8, 6, 5]

===========================================================
Iteration 7
===========================================================
Current Element = 3

Stack Before = [8, 6, 5]

Top(5) > 3

Nearest Greater = 5

Result = [-1, 8, 8, 6, 6, 6, 5]

Push 3

Stack After = [8, 6, 5, 3]

===========================================================
Iteration 8
===========================================================
Current Element = 7

Stack Before = [8, 6, 5, 3]

Pop 3
Pop 5
Pop 6

Stack = [8]

Top(8) > 7

Nearest Greater = 8

Result = [-1, 8, 8, 6, 6, 6, 5, 8]

Push 7

Stack After = [8, 7]

===========================================================
Iteration 9
===========================================================
Current Element = 9

Stack Before = [8, 7]

Pop 7
Pop 8

Stack = []

Nearest Greater = -1

Result = [-1, 8, 8, 6, 6, 6, 5, 8, -1]

Push 9

Stack After = [9]

===========================================================
Result Before Reverse
===========================================================

[-1, 8, 8, 6, 6, 6, 5, 8, -1]

===========================================================
Reverse Result
===========================================================

[-1, 8, 5, 6, 6, 6, 8, 8, -1]

===========================================================
Final Output
===========================================================

Input  : [9, 7, 3, 5, 4, 2, 6, 1, 8]

Output : [-1, 8, 5, 6, 6, 6, 8, 8, -1]
*/