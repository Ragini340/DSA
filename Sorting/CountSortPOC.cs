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

    }
}