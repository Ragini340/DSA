namespace DataStructure.Stack
{
    /*
    Brute force approach for nearest smaller element in right side. 
    ==========================================================
    Time Complexity
    ==========================================================
    Outer loop  = N
    Inner loop  = N

    Worst Case = O(N²)

    ==========================================================
    Space Complexity
    ==========================================================
    Extra Space = O(1)
    (Result list is not counted as auxiliary space.)
    ==========================================================
    */
    public class NearestSmallerElementToRight_UsingLeftToRightIteration
    {
        public static List<int> NearestSmallerElementToRightSide(List<int> inputList)
        {
            List<int> result = new List<int>(inputList.Count);

            //Iterating from left to right
            for (int i = 0; i <= inputList.Count - 1; i++)
            {
                bool found = false;
                for (int j = i + 1; j < inputList.Count; j++)
                {
                    if (inputList[j] < inputList[i])
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

Goal:
For every element, find the first smaller element on its right.
If no smaller element exists, store -1.

----------------------------------------------------------
Iteration 1
----------------------------------------------------------
i = 0
Current Element = 4

Check right side:
6 > 4
10 > 4
11 > 4
7 > 4
6 > 4
3 < 4  <-- First smaller found

Result = [3]

----------------------------------------------------------
Iteration 2
----------------------------------------------------------
i = 1
Current Element = 6

Check right side:
10 > 6
11 > 6
7 > 6
6 == 6 (Not smaller)
3 < 6  <-- First smaller found

Result = [3, 3]

----------------------------------------------------------
Iteration 3
----------------------------------------------------------
i = 2
Current Element = 10

Check right side:
11 > 10
7 < 10  <-- First smaller found

Result = [3, 3, 7]

----------------------------------------------------------
Iteration 4
----------------------------------------------------------
i = 3
Current Element = 11

Check right side:
7 < 11  <-- First smaller found

Result = [3, 3, 7, 7]

----------------------------------------------------------
Iteration 5
----------------------------------------------------------
i = 4
Current Element = 7

Check right side:
6 < 7  <-- First smaller found

Result = [3, 3, 7, 7, 6]

----------------------------------------------------------
Iteration 6
----------------------------------------------------------
i = 5
Current Element = 6

Check right side:
3 < 6  <-- First smaller found

Result = [3, 3, 7, 7, 6, 3]

----------------------------------------------------------
Iteration 7
----------------------------------------------------------
i = 6
Current Element = 3

Check right side:
5 > 3

No smaller element found.

Result = [3, 3, 7, 7, 6, 3, -1]

----------------------------------------------------------
Iteration 8
----------------------------------------------------------
i = 7
Current Element = 5

No elements on the right.

Result = [3, 3, 7, 7, 6, 3, -1, -1]

==========================================================
Final Output
==========================================================

Input  : [4, 6, 10, 11, 7, 6, 3, 5]

Output : [3, 3, 7, 7, 6, 3, -1, -1]
*/