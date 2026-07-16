namespace DataStructure.Stack
{
    /*
    Time Complexity (TC): O(n)

    Reason:
    - The for loop runs n times.
    - Every element is pushed onto the stack exactly once.
    - Every element is popped from the stack at most once.
    - Although there is a nested while loop, the total number of pop operations
      across the entire algorithm is at most n.

    Therefore,
    TC = O(n)

    ------------------------------------------------------------

    Space Complexity (SC): O(n)

    Reason:
    - Stack: In the worst case, it stores all n elements. => O(n)
    - Result List: Stores n answers. => O(n)

    Each element is pushed once and popped at most once, which makes the overall
    time complexity linear despite the nested while loop.
    */
    public class RightSmallerElementUsingStack
    {
        public static List<int> NearestSamllerElementToRight(List<int> input)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                //Pop all less than equal to elements 
                while (stack.Count > 0 && stack.Peek() >= input[i])
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
            List<int> input = new List<int> { 4, 6, 10, 11, 7, 3, 5 };
            List<int> result = NearestSamllerElementToRight(input);
            Console.WriteLine("Nearest smaller element in right for the given each list's element: " + string.Join(", ", result));
        }

    }
}
/*
Input:
4, 6, 10, 11, 7, 3, 5

We traverse from RIGHT to LEFT.

---------------------------------------------------------------------------------------------------------
| i | Current | Stack Before | Elements Popped | Stack After Pop | Result Added | Stack After Push |
---------------------------------------------------------------------------------------------------------
| 6 |    5    |      []      |      None       |       []        |      -1      |       [5]        |
| 5 |    3    |      [5]     |        5        |       []        |      -1      |       [3]        |
| 4 |    7    |      [3]     |      None       |       [3]       |       3      |      [3, 7]      |
| 3 |   11    |     [3,7]    |      None       |      [3,7]      |       7      |    [3, 7, 11]    |
| 2 |   10    |   [3,7,11]   |       11        |      [3,7]      |       7      |    [3, 7, 10]    |
| 1 |    6    |   [3,7,10]   |      10, 7      |       [3]       |       3      |      [3, 6]      |
| 0 |    4    |     [3,6]    |        6        |       [3]       |       3      |      [3, 4]      |
---------------------------------------------------------------------------------------------------------

Result before Reverse():
[-1, -1, 3, 7, 7, 3, 3]

Result after Reverse():
[3, 3, 7, 7, 3, -1, -1]

Output:
Nearest smaller element to right:
3, 3, 7, 7, 3, -1, -1

Explanation:
4  -> 3
6  -> 3
10 -> 7
11 -> 7
7  -> 3
3  -> -1
5  -> -1
*/