namespace DataStructure.Stack
{
    /*
     For the given list find the nearest smaller element in the left hand side.
     If there is no nearest smaller element in the left hand side then use the default value as -1.
    */
    /*
     Time Complexity: O(n) 
     Space Complexity: O(n)
    */
    public class NearestLeftSmallerElementUsingStack
    {
        public static List<int> NearestSmallerElement(List<int> inputList)
        {
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>(inputList.Count);

            for (int i = 0; i < inputList.Count; i++)
            {
                //Pop all greater than equal element from stack
                while (stack.Count > 0 && (stack.Peek() >= inputList[i]))
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
            List<int> input = new List<int> { 4, 6, 10, 11, 7, 6, 3, 5 };
            List<int> result = NearestSmallerElement(input);
            Console.WriteLine("Smaller left side nearest element for each elements: " + string.Join(", ", result));
        }

    }
}
/*
Input:
[4, 6, 10, 11, 7, 6, 3, 5]

---------------------------------------------------------------------------------------------------------------
| Iteration | Current Element | Stack Before | Operation                     | Result | Stack After | Output |
---------------------------------------------------------------------------------------------------------------
| 1         | 4               | []           | Stack empty                   | -1     | [4]         | [-1] |
| 2         | 6               | [4]          | 4 < 6 (No Pop)                | 4      | [4, 6]      | [-1, 4] |
| 3         | 10              | [4, 6]       | 6 < 10 (No Pop)               | 6      | [4, 6, 10]  | [-1, 4, 6] |
| 4         | 11              | [4, 6, 10]   | 10 < 11 (No Pop)              | 10     | [4, 6, 10, 11] | [-1, 4, 6, 10] |
| 5         | 7               | [4, 6, 10, 11] | Pop 11, Pop 10             | 6      | [4, 6, 7]   | [-1, 4, 6, 10, 6] |
| 6         | 6               | [4, 6, 7]    | Pop 7, Pop 6                  | 4      | [4, 6]      | [-1, 4, 6, 10, 6, 4] |
| 7         | 3               | [4, 6]       | Pop 6, Pop 4                  | -1     | [3]         | [-1, 4, 6, 10, 6, 4, -1] |
| 8         | 5               | [3]          | 3 < 5 (No Pop)                | 3      | [3, 5]      | [-1, 4, 6, 10, 6, 4, -1, 3] |
---------------------------------------------------------------------------------------------------------------

Step-by-Step Execution

Step 1:
Current Element = 4
Stack = []
Nearest Smaller = -1
Push 4
Stack = [4]

Step 2:
Current Element = 6
Stack = [4]
Top (4) < 6
Nearest Smaller = 4
Push 6
Stack = [4, 6]

Step 3:
Current Element = 10
Stack = [4, 6]
Top (6) < 10
Nearest Smaller = 6
Push 10
Stack = [4, 6, 10]

Step 4:
Current Element = 11
Stack = [4, 6, 10]
Top (10) < 11
Nearest Smaller = 10
Push 11
Stack = [4, 6, 10, 11]

Step 5:
Current Element = 7
Stack = [4, 6, 10, 11]
Pop 11
Pop 10
Top (6) < 7
Nearest Smaller = 6
Push 7
Stack = [4, 6, 7]

Step 6:
Current Element = 6
Stack = [4, 6, 7]
Pop 7
Pop 6
Top (4) < 6
Nearest Smaller = 4
Push 6
Stack = [4, 6]

Step 7:
Current Element = 3
Stack = [4, 6]
Pop 6
Pop 4
Stack becomes empty
Nearest Smaller = -1
Push 3
Stack = [3]

Step 8:
Current Element = 5
Stack = [3]
Top (3) < 5
Nearest Smaller = 3
Push 5
Stack = [3, 5]

Final Output:
[-1, 4, 6, 10, 6, 4, -1, 3]
 */