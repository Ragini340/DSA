namespace DataStructure.Sorting
{
    /*Counting Sort is a non-comparison sorting algorithm that works well when the range of input values is not too large.*/

    /* Time Complexity(TC): O(n)
     Reason:
     - Counting frequencies takes O(n)
     - Printing in ascending order takes O(n)
     - Printing in descending order takes O(n)
     - O(n) + O(n) + O(n) = O(n)

     Space Complexity(SC): O(1)

     Reason:
     - Uses a fixed-size frequency array of size 5.
     - Extra memory does not grow with input size.
    */

    public class CountSortPOC
    {
        public static void SortbyFreq(int[] arr)
        {
            // Create Frequency Array
            int[] freq = new int[5];
            // Count Frequencies
            for (int i = 0; i < arr.Length; i++)
            {
                int index = arr[i];
                freq[index]++;
            }
            Console.WriteLine("Count sort in ascending order:-");
            //Print in Ascending Order
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= freq[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            //Print in Descending Order
            Console.WriteLine("\nCount sort in decreasing order:-");
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= freq[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] countSortPOCArr = { 3, 1, 4, 4, 2, 4, 2, 3, 1, 2 };
            CountSortPOC.SortbyFreq(countSortPOCArr);
        }
        /*
        Input Array:
        [3, 1, 4, 4, 2, 4, 2, 3, 1, 2]

        Step 1: Create Frequency Array

        Initial Frequency Array (size = 5):
        Index : 0 1 2 3 4
        Value : 0 0 0 0 0

        --------------------------------------------------

        Step 2: Count Frequencies

        Read 3 -> freq[3]++
        Frequency: [0, 0, 0, 1, 0]

        Read 1 -> freq[1]++
        Frequency: [0, 1, 0, 1, 0]

        Read 4 -> freq[4]++
        Frequency: [0, 1, 0, 1, 1]

        Read 4 -> freq[4]++
        Frequency: [0, 1, 0, 1, 2]

        Read 2 -> freq[2]++
        Frequency: [0, 1, 1, 1, 2]

        Read 4 -> freq[4]++
        Frequency: [0, 1, 1, 1, 3]

        Read 2 -> freq[2]++
        Frequency: [0, 1, 2, 1, 3]

        Read 3 -> freq[3]++
        Frequency: [0, 1, 2, 2, 3]

        Read 1 -> freq[1]++
        Frequency: [0, 2, 2, 2, 3]

        Read 2 -> freq[2]++
        Frequency: [0, 2, 3, 2, 3]

        Final Frequency Array:
        Index : 0 1 2 3 4
        Value : 0 2 3 2 3

        --------------------------------------------------

        Step 3: Print in Ascending Order

        1 appears 2 times -> 1 1
        2 appears 3 times -> 2 2 2
        3 appears 2 times -> 3 3
        4 appears 3 times -> 4 4 4

        Ascending Order:
        1 1 2 2 2 3 3 4 4 4

        --------------------------------------------------

        Step 4: Print in Descending Order

        4 appears 3 times -> 4 4 4
        3 appears 2 times -> 3 3
        2 appears 3 times -> 2 2 2
        1 appears 2 times -> 1 1

        Descending Order:
        4 4 4 3 3 2 2 2 1 1
        */
    }
}