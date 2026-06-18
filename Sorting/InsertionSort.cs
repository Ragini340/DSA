namespace DataStructure.Sorting
{
    /*
     Insertion Sort is a comparison-based sorting algorithm that sorts an array by repeatedly taking an element from the unsorted portion 
     and inserting it into its correct position in the sorted portion of the array.
    */

    /*
    * Time Complexity of Insertion Sort:
    * Best Case    : O(n)   - When the array is already sorted.
    * Average Case : O(n²)  - When elements are in random order.
    * Worst Case   : O(n²)  - When the array is sorted in reverse order.
    *
    * Space Complexity: O(1)
    * - Sorting is done in-place and requires no extra array.
    */

    public class InsertionSort
    {
        public static void InsertionSorts(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }

        public static void Main(string[] args)
        {
            int[] insertionSortArr = { 1, 3, 2, 6, 8, 10, 9, 5 };
            Console.WriteLine("Insertion sorting: ");
            InsertionSort.InsertionSorts(insertionSortArr);
        }

        /*
        * Flow of Insertion Sort:
        *
        * 1. Start from the second element (index 1).
        * 2. Compare the current element with elements before it.
        * 3. If the left element is greater than the current element,
        *    swap them.
        * 4. Continue moving the current element left until it reaches
        *    its correct sorted position.
        * 5. Repeat the process for all remaining elements in the array.
        * 6. After all passes, the array becomes fully sorted.
        *
        * Example:
        * Input : 1 3 2 6 8 10 9 5
        * Pass 1: 1 3 2 6 8 10 9 5
        * Pass 2: 1 2 3 6 8 10 9 5
        * Pass 3: 1 2 3 6 8 10 9 5
        * Pass 4: 1 2 3 6 8 10 9 5
        * Pass 5: 1 2 3 6 8 10 9 5
        * Pass 6: 1 2 3 6 8 9 10 5
        * Pass 7: 1 2 3 5 6 8 9 10
        *
        * Output: 1 2 3 5 6 8 9 10
        */

    }
}