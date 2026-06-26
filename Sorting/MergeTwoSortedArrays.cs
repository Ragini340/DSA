namespace DataStructure.Sorting
{
    public class MergeTwoSortedArrays
    {
        /* Time Complexity: O(N + M)
         * Space Complexity: O(1) beacause it took extra space for storing result in arr3 not for sorting the array.
         */
        public static void MergeTwoSortedArray(int[] arr1, int[] arr2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;
            int n1 = arr1.Length;
            int n2 = arr2.Length;

            while (i < n1 && j < n2)
            {
                // Pick smaller of the two current elements and move ahead in the array of the picked element
                if (arr1[i] < arr2[j])
                {
                    arr3[k++] = arr1[i++];
                }
                else
                {
                    arr3[k++] = arr2[j++];
                }
            }

            // if there are remaining elements of the first array, move them
            while (i < n1)
            {
                arr3[k++] = arr1[i++];
            }

            // Else if there are remaining elements of the second array, move them
            while (j < n2)
            {
                arr3[k++] = arr2[j++];
            }

        }

        public static void Main(string[] args)
        {
            int[] arr1 = { 2, 5, 7, 12, 20, 24, 29 };
            int[] arr2 = { 6, 9, 12, 14, 15, 19 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            MergeTwoSortedArrays.MergeTwoSortedArray(arr1, arr2, arr3);
            Console.WriteLine("Merged two sorted arrays's elements: ");
            foreach (int sortedValue in arr3)
            {
                Console.Write(sortedValue + " ");
            }
        }

        /*       
        Input:
        arr1 = [2, 5, 7, 12, 20, 24, 29]
        arr2 = [6, 9, 12, 14, 15, 19]

        i = 0, j = 0, k = 0

        ---------------------------------------------------------------------------
        Step | arr1[i] | arr2[j] | Smaller | arr3 after insertion         | i | j | k
        ---------------------------------------------------------------------------
        1    |    2    |    6    |    2    | [2]                          | 1 | 0 | 1
        2    |    5    |    6    |    5    | [2, 5]                       | 2 | 0 | 2
        3    |    7    |    6    |    6    | [2, 5, 6]                    | 2 | 1 | 3
        4    |    7    |    9    |    7    | [2, 5, 6, 7]                 | 3 | 1 | 4
        5    |   12    |    9    |    9    | [2, 5, 6, 7, 9]              | 3 | 2 | 5
        6    |   12    |   12    |   12*   | [2, 5, 6, 7, 9, 12]          | 3 | 3 | 6
        7    |   12    |   14    |   12    | [2, 5, 6, 7, 9, 12, 12]      | 4 | 3 | 7
        8    |   20    |   14    |   14    | [2, 5, 6, 7, 9, 12, 12, 14]  | 4 | 4 | 8
        9    |   20    |   15    |   15    | [2, 5, 6, 7, 9, 12, 12, 14,
                                            15]                            | 4 | 5 | 9
        10   |   20    |   19    |   19    | [2, 5, 6, 7, 9, 12, 12, 14,
                                            15, 19]                        | 4 | 6 |10
        ---------------------------------------------------------------------------

        Now j == arr2.Length (6), so the first while loop ends.

        Copy Remaining Elements from arr1

        Remaining elements:
        20, 24, 29

        Step 11:
        arr3 = [2, 5, 6, 7, 9, 12, 12, 14, 15, 19, 20]
        i = 5, k = 11

        Step 12:
        arr3 = [2, 5, 6, 7, 9, 12, 12, 14, 15, 19, 20, 24]
        i = 6, k = 12

        Step 13:
        arr3 = [2, 5, 6, 7, 9, 12, 12, 14, 15, 19, 20, 24, 29]
        i = 7, k = 13

        Final Output:
        arr3 = [2, 5, 6, 7, 9, 12, 12, 14, 15, 19, 20, 24, 29]

        * At Step 6, arr1[i] == arr2[j] == 12.
        Since the condition is:
            if (arr1[i] < arr2[j])

        12 < 12 is false, so the element from arr2 is copied first.
        */

    }
}