namespace DataStructure.Stack
{
    /*
     For the given list find the nearest greater element in the left hand side.
     If there is no nearest greater element in the left hand side then use default value as -1.
    */

    /*
    Time Complexity: O(n)

   Reason:
   - We traverse the input list only once using a single for loop.
   - Every element is pushed into the stack exactly one time.
   - Every element is popped from the stack at most one time.
   - Although there is a while loop inside the for loop, the total number of pop operations across the entire execution is at most n.

   Therefore:
   Push operations = n
   Pop operations ≤ n

   Total operations = n + n = 2n

   Ignoring constants in Big-O notation:
   ------------------------------------------------------------------------------------
       Space Complexity: O(n)

   Reason:
   - We use an extra stack to store elements.
   - In the worst case (when the array is in decreasing order), no elements are popped.
   - All n elements remain in the stack.
   - We also store the answer in a result list of size n.

   Extra space used:
   Stack = O(n)
   Result List = O(n)

   Overall auxiliary space is considered O(n).
    */
    public class NearestGreaterElementToLeft
    {
        public static List<int> NearestGreaterElementToLeftSide(List<int> inputList)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                //Pop all less than or equal elements
                while (stack.Count > 0 && stack.Peek() <= inputList[i])
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
                stack.Push(inputList[i]);
            }

            return result;
        }

        public static void Main(string[] args)
        {
            List<int> input = new List<int> { 9, 7, 3, 5, 4, 2, 6, 1, 8 };
            List<int> result = NearestGreaterElementToLeftSide(input);
            Console.WriteLine("Nearest greater element in left for the given each list's element: " + string.Join(", ", result));
        }

    }
}
/*
Input:
9, 7, 3, 5, 4, 2, 6, 1, 8

Rule:
1. Remove all elements from stack which are <= current element.
2. If stack becomes empty -> answer = -1.
3. Otherwise top of stack is the nearest greater element on left.
4. Push current element into stack.

---------------------------------------------------------------------------
| i | Current | Stack Before | Pop Operation     | Answer | Stack After   |
---------------------------------------------------------------------------
| 0 |    9    | []           | None              |  -1    | [9]           |
| 1 |    7    | [9]          | None              |   9    | [9,7]         |
| 2 |    3    | [9,7]        | None              |   7    | [9,7,3]       |
| 3 |    5    | [9,7,3]      | Pop 3            |   7    | [9,7,5]       |
| 4 |    4    | [9,7,5]      | None              |   5    | [9,7,5,4]     |
| 5 |    2    | [9,7,5,4]    | None              |   4    | [9,7,5,4,2]   |
| 6 |    6    | [9,7,5,4,2]  | Pop 2,4,5        |   7    | [9,7,6]       |
| 7 |    1    | [9,7,6]      | None              |   6    | [9,7,6,1]     |
| 8 |    8    | [9,7,6,1]    | Pop 1,6,7        |   9    | [9,8]         |
---------------------------------------------------------------------------

Final Result:
[-1, 9, 7, 7, 5, 4, 7, 6, 9]
 */