namespace DataStructure.Array
{
    /*
    Given an array and multiple queries, where each query contains a start index and an end index, find the sum of elements between those indices (inclusive).
    */

    /*
    Input:
    arr = {-3, 6, 2, 4, 5, 2, 8, -9, 3}

    Queries:
    {1,3}
    {2,7}
    {4,8}
    {0,2}
    ------------------------------------------------------------
    Time Complexity (TC)

    Let:
    n = size of array
    q = number of queries

    Outer loop runs q times.

    For each query, inner loop traverses from start index to end index.

    Worst case:
    Each query may traverse the entire array.

    TC = O(q × n)

    For this example:
    n = 9
    q = 4

    Worst-case operations = 4 × 9 = 36

    ------------------------------------------------------------
    Space Complexity (SC)

    No extra data structures are used.
    Only variables:
    startIdx
    endIdx
    sum
    i
    j

    SC = O(1)
    */
    public class FindSumOfArrayElementsFromStartToEnd
    {
        public void SumOfArrayElementsFromStartToEnd(int[] arr, int[][] arr1)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                int startIdx = arr1[j][0];
                int endIdx = arr1[j][1];
                int sum = 0;
                for (int i = startIdx; i <= endIdx; i++)
                {
                    sum = sum + arr[i];
                }
                Console.WriteLine(sum);
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = { -3, 6, 2, 4, 5, 2, 8, -9, 3 };
            int[][] arr1 =
            { new int[]{ 1, 3 },
              new int[]{ 2, 7 },
              new int[]{ 4, 8 },
              new int[] {0, 2 }
            };

            FindSumOfArrayElementsFromStartToEnd obj = new FindSumOfArrayElementsFromStartToEnd();
            obj.SumOfArrayElementsFromStartToEnd(arr, arr1);
        }

        /*
        Array

        Index : 0   1   2   3   4   5   6    7   8
        Value : -3  6   2   4   5   2   8   -9   3

        ----------------------------------------
        Query 1 : {1, 3}
        ----------------------------------------

        startIdx = 1
        endIdx = 3
        sum = 0

        Iteration 1:
        i = 1
        sum = 0 + arr[1]
            = 0 + 6
            = 6

        Iteration 2:
        i = 2
        sum = 6 + arr[2]
            = 6 + 2
            = 8

        Iteration 3:
        i = 3
        sum = 8 + arr[3]
            = 8 + 4
            = 12

        Output = 12

        ----------------------------------------
        Query 2 : {2, 7}
        ----------------------------------------

        startIdx = 2
        endIdx = 7
        sum = 0

        i = 2
        sum = 0 + 2 = 2

        i = 3
        sum = 2 + 4 = 6

        i = 4
        sum = 6 + 5 = 11

        i = 5
        sum = 11 + 2 = 13

        i = 6
        sum = 13 + 8 = 21

        i = 7
        sum = 21 + (-9) = 12

        Output = 12

        ----------------------------------------
        Query 3 : {4, 8}
        ----------------------------------------

        startIdx = 4
        endIdx = 8
        sum = 0

        i = 4
        sum = 0 + 5 = 5

        i = 5
        sum = 5 + 2 = 7

        i = 6
        sum = 7 + 8 = 15

        i = 7
        sum = 15 + (-9) = 6

        i = 8
        sum = 6 + 3 = 9

        Output = 9

        ----------------------------------------
        Query 4 : {0, 2}
        ----------------------------------------

        startIdx = 0
        endIdx = 2
        sum = 0

        i = 0
        sum = 0 + (-3) = -3

        i = 1
        sum = -3 + 6 = 3

        i = 2
        sum = 3 + 2 = 5

        Output = 5

        ----------------------------------------
        Final Output
        ----------------------------------------

        12
        12
        9
        5
        */
    }
}