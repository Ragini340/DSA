namespace DataStructure.Stack
{
    /*
     Brute force approach for nearest smaller element in right side. 
       -------------------------------------------------------------------------
       Time Complexity
       -------------------------------------------------------------------------

       Outer loop runs N times.

       Inner loop may scan all elements to the right.

       Worst Case:
       (N-1) + (N-2) + ... + 2 + 1
       = N(N-1)/2
       = O(N²)

       Space Complexity = O(1)
       (Ignoring the output list.)
    */
    public class NearestSmallerElementToRight
    {
        public static List<int> NearestSmallerElementToRightSide(List<int> inputList)
        {
            List<int> result = new List<int>(inputList.Count);

            //Iterating from right to left
            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                bool found = false;
                for (int j = i + 1; j < inputList.Count; j++)
                {
                    if (inputList[i] > inputList[j])
                    {
                        result.Add(inputList[j]);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    result.Add(-1);
                }
            }

            result.Reverse();
            return result;
        }

        public static void Main(string[] args)
        {
            List<int> input = new List<int> { 4, 6, 10, 11, 7, 6, 3, 5 };
            List<int> result = NearestSmallerElementToRightSide(input);
            Console.WriteLine("Smaller right side nearest element for each elements: " + string.Join(", ", result));
        }

    }
}
/*
Input:
[4, 6, 10, 11, 7, 6, 3, 5]

The algorithm traverses from RIGHT to LEFT.
For every element, it searches the first smaller element on its right.

-------------------------------------------------------------------------
Iteration 1
-------------------------------------------------------------------------
i = 7
Current Element = 5

Right Side = None

No smaller element found.

result = [-1]

-------------------------------------------------------------------------
Iteration 2
-------------------------------------------------------------------------
i = 6
Current Element = 3

Compare with:
5

3 > 5 ? No

No smaller element found.

result = [-1, -1]

-------------------------------------------------------------------------
Iteration 3
-------------------------------------------------------------------------
i = 5
Current Element = 6

Compare with:
3

6 > 3 ? Yes

First smaller element = 3

result = [-1, -1, 3]

-------------------------------------------------------------------------
Iteration 4
-------------------------------------------------------------------------
i = 4
Current Element = 7

Compare with:
6

7 > 6 ? Yes

First smaller element = 6

result = [-1, -1, 3, 6]

-------------------------------------------------------------------------
Iteration 5
-------------------------------------------------------------------------
i = 3
Current Element = 11

Compare with:
7

11 > 7 ? Yes

First smaller element = 7

result = [-1, -1, 3, 6, 7]

-------------------------------------------------------------------------
Iteration 6
-------------------------------------------------------------------------
i = 2
Current Element = 10

Compare with:
11 -> 10 > 11 ? No
7  -> 10 > 7  ? Yes

First smaller element = 7

result = [-1, -1, 3, 6, 7, 7]

-------------------------------------------------------------------------
Iteration 7
-------------------------------------------------------------------------
i = 1
Current Element = 6

Compare with:
10 -> No
11 -> No
7  -> No
6  -> Equal (Not Smaller)
3  -> Yes

First smaller element = 3

result = [-1, -1, 3, 6, 7, 7, 3]

-------------------------------------------------------------------------
Iteration 8
-------------------------------------------------------------------------
i = 0
Current Element = 4

Compare with:
6  -> No
10 -> No
11 -> No
7  -> No
6  -> No
3  -> Yes

First smaller element = 3

result = [-1, -1, 3, 6, 7, 7, 3, 3]

-------------------------------------------------------------------------
Before Reverse
-------------------------------------------------------------------------

result = [-1, -1, 3, 6, 7, 7, 3, 3]

-------------------------------------------------------------------------
After Reverse
-------------------------------------------------------------------------

result = [3, 3, 7, 7, 6, 3, -1, -1]

-------------------------------------------------------------------------
Final Output
-------------------------------------------------------------------------

Input  : [4, 6, 10, 11, 7, 6, 3, 5]
Output : [3, 3, 7, 7, 6, 3, -1, -1] 
*/